using fixAL_Backend.DTOs.Review;

namespace fixAL_Backend.Interfaces;

public interface IReviewServices
{
    Task<List<ReviewDto>> GetByWorker(int workerId);
    Task<ReviewDto> CreateReview(int userId, CreateReviewDto reviewDto);
    Task<ReviewDto> UpdateReview(int id, UpdateReviewDto reviewDto);
    Task DeleteReview(int id);
}