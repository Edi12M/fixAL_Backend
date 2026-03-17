using fixAL_Backend.DTOs.User;

namespace fixAL_Backend.DTOs.Review;

public class ReviewDto
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public UserDto User { get; set; }
    public int WorkerId { get; set; }
}