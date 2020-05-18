using System;
using System.Collections.Generic;
using MovieGenre;

namespace Class10
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviesMilenium = new List<Movie> {
                new Movie("Conjuring", Genre.Horror, 3),
                new Movie("The Nun", Genre.Horror, 5),
                new Movie("Conjuring2", Genre.Horror, 4)
            };
            var moviesCineplex = new List<Movie> {
                new Movie("Edge of tomorrow", Genre.SciFi, 3),
                new Movie("Vanilla sky", Genre.Drama, 2),
                new Movie("Scary movie", Genre.Comedy, 1),
                new Movie("Mr and Mrs Smith", Genre.Action, 3)
                };
            var hallsMilenium = new List<int> { 1, 2, 3, 4, 5 };
            var hallsCineplex = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var cineplex = new Cinema("Cineplex", hallsMilenium, moviesCineplex);
            var milenium = new Cinema("Milenium", hallsCineplex, moviesMilenium);
            Console.WriteLine("Type 1 for Cineplex and 2 for Milenium:");
            var userInput = Console.ReadLine();
            if (userInput == "1")
            {
                CinemaChosen(cineplex, moviesCineplex);
            }
            else if(userInput == "2")
            {
                CinemaChosen(milenium, moviesMilenium);
            }
        }
        public static void CinemaChosen(Cinema cinema, List<Movie> movies)
        {
            Console.WriteLine($"You chose {cinema.Name} cinema. Choose an option:\n 1 - if you want to see all movies\n 2 - if you want to see movies by genre");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("Choose a movie:");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine($"{i} {movies[i].Title}");
                }
                var userMovie = Console.ReadLine();
                // try catch
                var choseMovieIndex = int.Parse(userMovie);
                var choseMovie = movies[choseMovieIndex];
                cinema.MoviePlaying(choseMovie.Title);
            }
        }
    }
}
