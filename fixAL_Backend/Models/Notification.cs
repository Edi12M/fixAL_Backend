using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Notification
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required string NotificationText { get; set; }
    public bool IsRead { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
}