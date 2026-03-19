using fixAL_Backend.DTOs.User;
using fixAL_Backend.DTOs.Worker;

namespace fixAL_Backend.Interfaces;

public interface IWorkerServices
{
    Task<List<WorkerDto>> GetWorkers();
    Task<WorkerDto> GetWorkerById(int id);
    Task<WorkerDto> CreateWorker(int userId, CreateWorkerDto workerDto);
    Task<WorkerDto> UpdateWorker(int id, UpdateWorkerDto workerDto);
    Task Verify(int id);
    Task DeleteWorker(int id);
}