using fixAL_Backend.Models;

namespace fixAL_Backend.DTOs.User;

public class UserDto
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required int PhoneNumber { get; set; }
    public required int CityId { get; set; }
    public required Roles Role { get; set; }
    public required DateTime CreatedAt { get; set; }
}