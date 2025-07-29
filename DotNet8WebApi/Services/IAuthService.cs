using DotNet8WebApi.Entities;
using DotNet8WebApi.Models;

namespace DotNet8WebApi.Services;

public interface IAuthService
{
    public Task<User?> RegisterAsync(UserDto request);
    public Task<TokenResponseDto?> LoginAsync(UserDto request);
    public Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
}