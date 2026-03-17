namespace fixAL_Backend.DTOs.Category;

public class UpdateCategoryDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}