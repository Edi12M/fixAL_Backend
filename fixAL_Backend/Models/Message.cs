using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Message
{
    public int Id { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required string TextMessage { get; set; }
    
    public int SenderId { get; set; }
    [ForeignKey("SenderId")]
    public User Sender { get; set; }
    
    public int ReceiverId { get; set; }
    [ForeignKey("ReceiverId")]
    public User Receiver { get; set; }
}