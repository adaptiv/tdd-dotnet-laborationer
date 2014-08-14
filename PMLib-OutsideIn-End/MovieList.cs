using System.Collections.Generic;

namespace PMLibOutsideInEnd
{
    public class MovieList
    {

        private List<Movie> _movies = new List<Movie>();

        public int Size()
        {
            return _movies.Count;
        }

        public void Clear()
        {
            _movies.Clear();
        }

    }
}