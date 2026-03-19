using fixAL_Backend.DTOs.Notification;

namespace fixAL_Backend.Interfaces;

public interface INotificationServices
{
    Task<List<NotificationDto>> GetByUser(int userId);
    Task MarkAsRead(int id);
    Task MarkAllAsRead(int userId);
    Task CreateNotification(int userId, string message);

}