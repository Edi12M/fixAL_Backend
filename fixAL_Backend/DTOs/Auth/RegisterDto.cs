namespace fixAL_Backend.DTOs.Auth;

public class RegisterDto
{
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required int PhoneNumber { get; set; }
    public required int CityId { get; set; }
}