using System;
using System.Collections.Generic;
using System.Text;

namespace Class10
{
    public class Cinema
    {
        public Cinema (string name, List<int> halls, List<Movie> movies)
        {
            Name = name;
            Halls = Halls;
            Movies = Movies;
        }
        public string Name { get; set; }
        public int Halls { get; set; }
        public  List<Movie> Movies { get; set; }

        public void MoviePlaying(string movie)
        {
            Console.WriteLine($"Watching {movie}");
        }
    }
}
