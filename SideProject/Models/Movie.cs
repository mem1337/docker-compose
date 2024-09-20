using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SideProject.Models;

////Movies
public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long MovieId { get; set; }
    public string? MovieName {get; set; }
    public string? MovieDsc {get; set; }
    public int MovieYear { get; set; }

    public ICollection<Favorite>? UserFavorites { get; set;}
    public ICollection<Rating>? Ratings { get; set; }
}

//Ratings
public class Rating
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long RatingId { get; set; }
    //Foreign Keys
    public long UserId { get; set; }
    public User? User { get; set; }
    public long MovieId { get; set; }
    public Movie? Movie { get; set; }

    public int UserRating { get; set; }
}