namespace SideProject.Models;
//Movies
public class Movie
{
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
    public long RatingId { get; set; }
    public string? UserId { get; set; }
    public long MovieId { get; set; }
    public int UserRating { get; set; }

    public List<User>? Users { get; set; }
    public List<Movie>? Movies { get; set; }
}