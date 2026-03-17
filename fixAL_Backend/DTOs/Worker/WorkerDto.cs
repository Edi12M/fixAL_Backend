using fixAL_Backend.DTOs.Category;
using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.DTOs.Worker;

public class WorkerDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public UserDto User { get; set; }
    public int ExperienceYears { get; set; }
    public bool IsVerified { get; set; }
    public string? ProfileImg { get; set; }
    public List<CategoryDto> Categories { get; set; }
    
}