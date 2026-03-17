namespace fixAL_Backend.DTOs.Service;

public class UpdateServiceDto
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
    public int CityId { get; set; }
}