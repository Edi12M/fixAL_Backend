namespace fixAL_Backend.DTOs.User;

public class UpdateUserDto
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int? PhoneNumber { get; set; }
    public int? CityId { get; set; }
}