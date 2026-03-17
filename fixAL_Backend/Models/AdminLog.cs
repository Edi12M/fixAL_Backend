using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class AdminLog
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string Action { get; set; }
    public string PerformedBy { get; set; }
    
    public int AdminId { get; set; }
    [ForeignKey("AdminId")]
    public User Admin { get; set; }
}