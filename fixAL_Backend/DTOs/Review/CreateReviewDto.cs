namespace fixAL_Backend.DTOs.Review;

public class CreateReviewDto
{
    public required int BookingId { get; set; }
    public required int WorkerId { get; set; }
    public required int Rating { get; set; }
    public required string Comment { get; set; }
}