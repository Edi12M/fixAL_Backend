using fixAL_Backend.DTOs.Service;
using fixAL_Backend.DTOs.User;
using fixAL_Backend.Models;

namespace fixAL_Backend.DTOs.Booking;

public class BookingsDto
{
    public int  Id { get; set; }
    public DateTime BookingDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public Status  Status { get; set; }
    public string? Notes { get; set; }
    public UserDto User { get; set; }
    public ServiceDto Service { get; set; }
}