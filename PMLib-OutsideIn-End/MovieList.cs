using System.Collections;
using System.Collections.Generic;

namespace PMLibOutsideInEnd
{
    public class MovieList : IEnumerable<Movie>
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

        public void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            return _movies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}