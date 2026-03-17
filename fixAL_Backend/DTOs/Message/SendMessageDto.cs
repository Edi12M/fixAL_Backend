namespace fixAL_Backend.DTOs.Message;

public class SendMessageDto
{
    public required string TextMessage { get; set; }
    public required int ReceiverId { get; set; }
}