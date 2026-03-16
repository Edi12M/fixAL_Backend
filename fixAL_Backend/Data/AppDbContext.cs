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
}