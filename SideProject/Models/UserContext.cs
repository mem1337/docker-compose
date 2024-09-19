using Microsoft.EntityFrameworkCore;

namespace SideProject.Models;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; } = null!;
}