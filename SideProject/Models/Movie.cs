namespace SideProject.Models;
using System.ComponentModel.DataAnnotations;
////Movies
public class Movie
{
    [Key]
    public long MovieId { get; set; }
    public string? MovieName {get; set; }
    public string? MovieDsc {get; set; }
    public int MovieYear { get; set; }

    public List<Favorite>? UserFavorites { get; set; }
    public List<Rating>? Ratings { get; set; }
}

//Ratings
public class Rating
{
    [Key]
    public long RatingId { get; set; }
    public string? UserId { get; set; }
    public long MovieId { get; set; }
    [Range(0, 6)]
    public int UserRating { get; set; }

    public List<User>? Users { get; set; }
    public List<Movie>? Movies { get; set; }
}