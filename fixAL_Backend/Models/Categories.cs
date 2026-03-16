namespace fixAL_Backend.Models;

public class Categories
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    
    public ICollection<Worker> Workers { get; set; } = new List<Worker>();
    public ICollection<Services> Services { get; set; } = new List<Services>();
}
