using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Services
{

    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }

    public int WorkerId { get; set; }
    [ForeignKey("WorkerId")]
    public Worker Worker { get; set; }

    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Categories Category { get; set; }
    
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
