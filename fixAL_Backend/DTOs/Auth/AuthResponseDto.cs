using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.DTOs.Auth;

public class AuthResponseDto
{
    public required string Token { get; set; }
    public required UserDto User { get; set; }
}