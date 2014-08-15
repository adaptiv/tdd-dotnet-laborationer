using System;

namespace PMLibOutsideInEnd
{
    public class Movie : IEquatable<Movie>
    {
        public string Titel { get; set; }

        public Movie()
        {
            
        }

        public Movie(string titel)
        {
            Titel = titel;
        }

        public bool Equals(Movie other)
        {
            return other.Titel.Equals(Titel);
        }
    }
}