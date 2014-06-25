/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */
using System;

namespace PMLibDependStart
{
	/// <summary>
	/// Description of a movie.
	/// </summary>
	public class Movie
	{
		private readonly string _title;

		/// <summary>
		/// Creates a movie with a title.
		/// </summary>
		/// <param name="title">The title of the movie</param>
		public Movie(String title)
		{
			this._title = title;
		}

		public string Title
		{
			get { return _title; }
		}
	}
}
