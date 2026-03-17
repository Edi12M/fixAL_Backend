namespace fixAL_Backend.DTOs.Worker;

public class CreateWorkerDto
{
    public string? Description { get; set; }
    public required int ExperienceYears { get; set; }
    public string? ProfileImg { get; set; }
    public required List<int> CategoryIds { get; set; }
}