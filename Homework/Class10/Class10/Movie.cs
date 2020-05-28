using MovieGenre;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Class10
{
}
public class Movie
{
    public Movie()
    {

    }
    public Movie(string title, Genre genre, int rating)
    {
        Title = title;
        Genre = genre;
        if (CheckRatingIsItValid(rating))
        {
            Rating = rating;
        }
        TicketPrice = rating * 5;
    }
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public int Rating { get; set; }
    public double TicketPrice { get; set; }

    static bool CheckRatingIsItValid(int rating)
    {
        if (rating < 1 || rating > 5) throw new OverflowException("Rating must be between 1 and 5.");

        return true;
    }

    public void MovieLargerThanRaiting(List<Movie> movies, int rating)
    {
        List<Movie> movieRating = movies.Where(movie => movie.Rating > rating).ToList();
    }
}
