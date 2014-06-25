using System;
using System.Collections.Generic;

namespace PMLibRefactorEnd
{
	public class MovieLibrary
	{
		private readonly IList<Movie> _movies = new List<Movie>();

		public void Add(Movie movieToAdd)
		{
			_movies.Add(movieToAdd);
		}

		public IList<string> RenderMovieLibrary()
		{
			return RenderMovieTable(_movies);
		}

		private IList<string> RenderMovieTable(IList<Movie> moviesToRender)
		{
			var result = new List<String>();
			result.Add(RenderHeading());
			result.AddRange(RenderMovies(moviesToRender));
			return result;
		}

		private IEnumerable<string> RenderMovies(IList<Movie> moviesToRender)
		{
			var result = new List<String>();
			foreach (var movie in moviesToRender)
			{
				result.Add(movie.Render());
			}
			return result;
		}

		private string RenderHeading()
		{
			return "*********** Movies in Library ***********";
		}

		public IList<string> RenderLibrarySortedByTitle()
		{
			return RenderMovieTable(SortMoviesByTitle(_movies));
		}

		private IList<Movie> SortMoviesByTitle(IList<Movie> moviesToSort)
		{
			var sorted = new List<Movie>(moviesToSort);
			sorted.Sort();
			return sorted;
		}
	}
}