namespace fixAL_Backend.DTOs.Worker;

public class UpdateWorkerDto
{
    public string? Description { get; set; }
    public int? ExperienceYears { get; set; }
    public string? ProfileImg { get; set; }
    public List<int>? CategoryIds { get; set; }
}