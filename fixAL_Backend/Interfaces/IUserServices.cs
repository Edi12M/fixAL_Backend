using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.Interfaces;

public interface IUserServices
{
    Task<List<UserDto>> GetAllUsers();
    Task<UserDto> GetUserById(int userId);
    Task<UserDto> UpdateUser(int id, UpdateUserDto dto);
    Task<UserDto> DeleteUser(int userId);
}