using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.DTOs.Message;

public class MessageDto
{
    public int Id { get; set; }
    public string TextMessage { get; set; }
    public DateTime SentAt { get; set; }
    public UserDto Sender { get; set; }
    public int ReceiverId { get; set; }
}