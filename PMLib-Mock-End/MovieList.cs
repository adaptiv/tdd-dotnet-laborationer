﻿/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */

using System.Collections.Generic;

namespace PMLibMockEnd
{
	/// <summary>
	/// List of movies in the collection.
	/// </summary>
	public class MovieList
	{
		private readonly IList<Movie> _movies = new List<Movie>();

		/// <summary>
		/// Determines if the collection is empty or not.
		/// </summary>
		/// <returns>True if the collection is empty, false otherwise</returns>
		public virtual bool IsEmpty()
		{
			return _movies.Count == 0;
		}
		
		/// <summary>
		/// Determines the number of movies in the collection.
		/// </summary>
		/// <returns>Number of movies</returns>
		public virtual int NumberOfMovies()
		{
			return _movies.Count;
		}
		
		/// <summary>
		/// Adds given movie to the collection.
		/// </summary>
		/// <param name="movie">Movie to add to the collection</param>
		public virtual void Add(Movie movie)
		{
			_movies.Add(movie);
		}

		public virtual IEnumerator<Movie> GetEnumerator()
		{
			return _movies.GetEnumerator();

		}
	}
}