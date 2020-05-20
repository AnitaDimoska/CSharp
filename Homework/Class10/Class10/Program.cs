using System;
using System.Collections.Generic;
using System.Linq;
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
                new Movie("Conjuring2", Genre.Horror, 4),
                new Movie("Edge of tomorrow", Genre.SciFi, 3),
                new Movie("Vanilla sky", Genre.Drama, 2),
                new Movie("Scary movie", Genre.Comedy, 1),
                new Movie("Mr and Mrs Smith", Genre.Action, 3)
            };
            var moviesCineplex = new List<Movie> {
                new Movie("Edge of tomorrow", Genre.SciFi, 3),
                new Movie("Conjuring", Genre.Horror, 3),
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
            else if (userInput == "2")
            {
                CinemaChosen(milenium, moviesMilenium);
            }
            else
            {
                throw new Exception("The entry is not valid!");
            }
            Console.ReadLine();
        }
        public static void CinemaChosen(Cinema cinema, List<Movie> movies)
        {
            Console.WriteLine($"You chose {cinema.Name} cinema. Choose an option:\n 1 - if you want to see all movies\n 2 - if you want to see movies by genre");
            var userChoice = Console.ReadLine();
            if (userChoice == null)
                throw new NullReferenceException("The choice is not valid. NullReferenceException");

            if (userChoice != "1" && userChoice != "2")
                throw new Exception("The choice is not valid.");


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

            else if (userChoice == "2")
            {
                Console.WriteLine("Choose a genre from the list with typing appropriate number: \n 1. Comedy,\n 2. Horror,\n 3. Action, \n 4. Drama,\n 5. SciFi");
                var userChoiceByGenre = Console.ReadLine();
                Genre genre = Genre.Action;
                switch (userChoiceByGenre)
                {
                    case "1":
                        genre = Genre.Comedy;
                        break;
                    case "2":
                        genre = Genre.Horror;
                        break;
                    case "3":
                        genre = Genre.Action;
                        break;
                    case "4":
                        genre = Genre.Drama;
                        break;
                    case "5":
                        genre = Genre.SciFi;
                        break;
                }
                if (userChoiceByGenre == null)
                    throw new NullReferenceException("The choice is not valid. NullReferenceException");

                if (userChoice != "1" && userChoice != "2")
                    throw new Exception("The choice is not valid.");

                var moviesToShow = movies.Where(x => x.Genre == genre).ToList();
                Console.WriteLine("Choose a movie:");
                for (int i = 0; i < moviesToShow.Count; i++)
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
