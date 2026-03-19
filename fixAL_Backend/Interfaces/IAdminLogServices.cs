using fixAL_Backend.DTOs.Admin;

namespace fixAL_Backend.Interfaces;

public interface IAdminLogServices
{
        Task<List<AdminDto>> GetAll();
        Task Log (int adminLogId, string action);
}