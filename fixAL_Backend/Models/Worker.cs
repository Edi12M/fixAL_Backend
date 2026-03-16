using System.ComponentModel.DataAnnotations.Schema;

namespace fixAL_Backend.Models;

public class Worker
{
    public int Id { get; set; }
    public string bio  { get; set; }
    public decimal pricePerHour { get; set; }
    public string proffesion { get; set; }
    public bool isAvailable { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    // This means:
    // - A Worker **belongs to many** Category 
    //     - A Category **has many** Workers (many plumbers can exist)
    
    //Navigation property : worker.category.name
    public ICollection<Categories> Categories { get; set; } = new List<Categories>();
    public ICollection<Services> Services { get; set; } = new List<Services>();
    
    
}