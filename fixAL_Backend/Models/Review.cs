using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Review
{
    public int Id { get; set; }
    public required string Comment { get; set; }
    public required int Rating { get; set; } // Assuming rating is an integer, e.g., 1-5
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;

    public int WorkerId { get; set; }
    [ForeignKey("WorkerId")]
    public Worker Worker { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
}