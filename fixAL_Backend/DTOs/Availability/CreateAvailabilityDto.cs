namespace fixAL_Backend.DTOs.Availability;

public class CreateAvailabilityDto
{
    public required DateTime Date { get; set; }
    public required TimeSpan StartTime { get; set; }
    public required TimeSpan EndTime { get; set; }
}