using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Availability
{
    public int Id { get; set; }
    public required DateTime StartTime { get; set; }
    public required DateTime EndTime { get; set; }
    
    public int WorkerId { get; set; }
    [ForeignKey("WorkerId")]
    public Worker Worker { get; set; }
}