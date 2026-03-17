namespace fixAL_Backend.DTOs.Notification;

public class NotificationDto
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
    public int UserId { get; set; }
}