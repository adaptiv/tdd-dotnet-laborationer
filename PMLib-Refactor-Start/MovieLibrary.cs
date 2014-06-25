using System;
using System.Collections.Generic;
using System.Text;

namespace PMLibRefactorStart
{
	public class MovieLibrary
	{
		private readonly IList<Movie> _movies = new List<Movie>();

		public IList<String> GetMovies()
		{
			IList<String> result = new List<String>();
			result.Add("*********** Movies in Library ***********");
			foreach (var movie in _movies)
			{
				var builder = new StringBuilder();
				builder.Append(movie.Title);
				builder.Append(" by ");
				builder.Append(movie.Director);
				builder.Append(", ");
				builder.Append(movie.Length);
				builder.Append(" mins, ");
				builder.Append("rated ");
				builder.Append(movie.Rating);
				result.Add(builder.ToString());
			}
			return result;
		}

		public void Add(Movie movieToAdd)
		{
			_movies.Add(movieToAdd);
		}

		public IList<String> GetMoviesByTitle()
		{
			var sorted = new List<Movie>(_movies);
			sorted.Sort();

			IList<String> result = new List<String>();
			result.Add("*********** Movies in Library ***********");
			foreach (var movie in sorted)
			{
				var builder = new StringBuilder();
				builder.Append(movie.Title);
				builder.Append(" by ");
				builder.Append(movie.Director);
				builder.Append(", ");
				builder.Append(movie.Length);
				builder.Append(" mins, ");
				builder.Append("rated ");
				builder.Append(movie.Rating);
				result.Add(builder.ToString());
			}
			return result;
		}

	}
}