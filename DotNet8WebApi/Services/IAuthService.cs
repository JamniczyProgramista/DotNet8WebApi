using DotNet8WebApi.Entities;
using DotNet8WebApi.Models;

namespace DotNet8WebApi.Services;

public interface IAuthService
{
    public Task<User?> RegisterAsync(UserDto request);
    public Task<string?> LoginAsync(UserDto request);
}