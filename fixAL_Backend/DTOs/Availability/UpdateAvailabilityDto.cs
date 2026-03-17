namespace fixAL_Backend.DTOs.Availability;

public class UpdateAvailabilityDto
{
    public DateTime? Date { get; set; }
    public TimeSpan? StartTime { get; set; }
    public TimeSpan? EndTime { get; set; }
}