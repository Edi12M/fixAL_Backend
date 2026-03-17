namespace fixAL_Backend.DTOs.Availability;

public class AvailabilityDto
{
    public int Id { get; set; }
    public int WorkerId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public bool IsBooked { get; set; }
}