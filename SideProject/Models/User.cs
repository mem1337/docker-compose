using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SideProject.Models;

public enum Role{ Admin = 0, Moderator = 1, User = 2}

//Users
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long UserId { get; set; }
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    public Role Role { get; set; }

    public ICollection<Favorite>? UserFavorites { get; set; }
    public ICollection<Rating>? Ratings { get; set; }
}

//Favorites
public class Favorite
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long FavId { get; set; }
    //Foreign keys
    public long UserId { get; set; }
    public User? User { get; set; }
    public long MovieId { get; set; }
    public Movie? Movie { get; set; }
}