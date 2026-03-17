using System.ComponentModel.DataAnnotations.Schema;


namespace fixAL_Backend.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required String LastName { get; set; }
    public required string  Email { get; set; }
    public required string Password { get; set; }
    public required int phoneNr  { get; set; }
    
    public int CityId { get; set; }
    [ForeignKey("CityId")]
    public City City { get; set; }

    public Roles Role { get; set; } = Roles.USER; //default
    
    
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public ICollection<Message> SentMessages { get; set; } = new List<Message>();
    public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    public ICollection<AdminLog> AdminLogs { get; set; } = new List<AdminLog>();
    

}