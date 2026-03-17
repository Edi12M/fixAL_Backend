using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.DTOs.Admin;

public class AdminDto
{
    public int Id { get; set; }
    public int AdminId { get; set; }
    public UserDto Admin { get; set; }
    public string Action { get; set; }
    public DateTime Date { get; set; }
}