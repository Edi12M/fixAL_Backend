using fixAL_Backend.DTOs.Category;

namespace fixAL_Backend.Interfaces;

public interface ICategoryServices
{
        Task<List<CategoryDto>> GetCategories();
        Task<CategoryDto> GetCategoryById(int id);
        Task<CategoryDto> CreateCategory(CreateCategoryDto categoryDto);
        Task<CategoryDto> UpdateCategory(int id, UpdateCategoryDto categoryDto);
        Task DeleteCategory(int id);
}