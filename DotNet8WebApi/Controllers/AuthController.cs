using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DotNet8WebApi.Entities;
using DotNet8WebApi.Models;
using DotNet8WebApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DotNet8WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(IAuthService authService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(UserDto request)
    {
        var user = await authService.RegisterAsync(request);
        if (user is null)
        {
            return BadRequest("User already exists");
        }
        return Ok(user);
    }
    
    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(UserDto request)
    {
        var token = await authService.LoginAsync(request);

        if (token is null)
        {
            return BadRequest("Invalid username or password");
        }
        return Ok(token);
    }
}