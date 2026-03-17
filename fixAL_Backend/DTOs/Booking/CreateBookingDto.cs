namespace fixAL_Backend.DTOs.Booking;

public class CreateBookingDto
{
    public string? Notes { get; set; }
    public required int ServiceId { get; set; }
    public required DateTime BookingDate { get; set; }
}