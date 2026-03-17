namespace fixAL_Backend.DTOs.Service;

public class CreateServiceDto
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required decimal Price { get; set; }
    public required int CategoryId { get; set; }
    public required int CityId { get; set; }
}