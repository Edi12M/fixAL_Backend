using fixAL_Backend.DTOs.Auth;
using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.Interfaces;

public interface IAuthServices
{
    Task<AuthResponseDto> Register(RegisterDto dto);
    Task<AuthResponseDto> Login(LoginDto dto);
    Task Logout();
    Task<UserDto> GetCurrentUser(int userId);
}