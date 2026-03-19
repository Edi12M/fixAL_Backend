using fixAL_Backend.DTOs.Service;

namespace fixAL_Backend.Interfaces;

public interface IServicesServices
{
    Task<List<ServiceDto>> GetServices();
    Task<ServiceDto> GetServiceById(int id);
    Task<List<ServiceDto>> GetServicesByWorker(int workerId);
    Task<ServiceDto> CreateService(CreateServiceDto serviceDto);
    Task<ServiceDto> UpdateService(int id, UpdateServiceDto serviceDto);
    Task DeleteService(int id);
}
