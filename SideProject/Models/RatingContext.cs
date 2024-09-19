using Microsoft.EntityFrameworkCore;

namespace SideProject.Models;

public class RatingContext : DbContext
{
    public RatingContext(DbContextOptions<RatingContext> options)
        : base(options)
    {
    }
    public DbSet<Rating> Ratings { get; set; } = null!;
}