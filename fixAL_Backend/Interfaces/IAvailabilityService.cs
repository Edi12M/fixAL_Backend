using fixAL_Backend.DTOs.Availability;

namespace fixAL_Backend.Interfaces;

public interface IAvailabilityService
{
    Task<List<AvailabilityDto>> GetAvailabilityByWorker (int workerId);
    Task<AvailabilityDto> CreateAvailability(int workerId, CreateAvailabilityDto availabilityDto);
    Task<AvailabilityDto> UpdateAvailability(int id, UpdateAvailabilityDto availabilityDto);
    Task DeleteAvailability(int id);
}