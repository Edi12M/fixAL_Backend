using fixAL_Backend.DTOs.Category;
using fixAL_Backend.DTOs.Worker;

namespace fixAL_Backend.DTOs.Service;

public class ServiceDto
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public WorkerDto  Worker { get; set; }
    public CategoryDto Category { get; set; }
    public int CityId { get; set; }
}