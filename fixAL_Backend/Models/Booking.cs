using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Booking
{
    public int Id { get; set; }
    public DateTime BookingDate { get; set; }
    public Status Status { get; set; } = Status.PENDING; // default
    public string? Notes { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow; // auto-set

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    public int ServiceId { get; set; }
    [ForeignKey("ServiceId")]
    public Services Service { get; set; }
}

public enum Status
{
    PENDING,
    ONGOING,
    FINISHED,
    CANCELLED
}