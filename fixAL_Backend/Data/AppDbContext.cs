using fixAL_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace fixAL_Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Services> Services { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Review> Reviews { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        //A message has one Sender, a User can have many SentMessages, the foreign key is SenderId
        modelBuilder.Entity<Message>()
            .HasOne(m => m.Sender)
            .WithMany(u => u.SentMessages)
            .HasForeignKey(m => m.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        // A message has one Receiver, a User can have many ReceivedMessages, the foreign key is ReceiverId
        modelBuilder.Entity<Message>()
            .HasOne(m => m.Receiver)
            .WithMany(u => u.ReceivedMessages)
            .HasForeignKey(m => m.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}