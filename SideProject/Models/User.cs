namespace SideProject.Models;
using System.ComponentModel.DataAnnotations;

public enum Role{ Admin = 0, Moderator = 1, User = 2}

//Users
public class User
{
    [Key]
    public long UserId { get; set; }
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    public Role Role { get; set; }

    public List<Favorite>? UserFavorites { get; set; }
    public List<Rating>? Ratings { get; set; }
}

//Favorites
public class Favorite
{
    [Key]
    public long FavId { get; set; }
    public long UserId { get; set; }
    public long MovieId { get; set; }

    public List<User>? Users { get; set; }
    public List<Movie>? Movies { get; set; }
}