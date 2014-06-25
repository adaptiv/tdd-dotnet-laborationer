/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PMLibBehaviorEnd
{
	/// <summary>
	/// Specifies design of MovieList.
	/// </summary>
	[TestFixture]
	public class SmallMovieListTest
	{
		private Movie _jawsMovie;
		private Movie _theShiningMovie;
		private Movie _etMovie;
		private MovieList _movieList;
		
		[SetUp]
		public void SetUp()
		{
			_jawsMovie = CreateNamedMovie("Jaws");
			_theShiningMovie = CreateNamedMovie("The Shining");
			_etMovie = CreateNamedMovie("E.T.");
			_movieList = CreateSmallMovieList(_jawsMovie, _theShiningMovie, _etMovie);		
		}

		private Movie CreateNamedMovie(String title)
		{
			return new Movie(title);
		}

		private MovieList CreateSmallMovieList(params Movie[] movies)
		{
			_movieList = new MovieList();
			foreach (var movie in movies)
			{
				_movieList.Add(movie);
			}
			return _movieList;
		}
		
		[Test]
		public void ShouldIndicateNumberOfMovies()
		{
			Assert.AreEqual(3, _movieList.NumberOfMovies());
		}
		
		[Test]
		public void ShouldContainAddedMovies()
		{
			IList<Movie> expectedMovies = new List<Movie>();
			expectedMovies.Add(_etMovie);
			expectedMovies.Add(_jawsMovie);
			expectedMovies.Add(_theShiningMovie);
			
			ListOfMoviesAreEqual(expectedMovies, _movieList);
		}

		private void ListOfMoviesAreEqual(IList<Movie> expectedMovies, MovieList actualMovies)
		{
			Assert.AreEqual(expectedMovies.Count, actualMovies.NumberOfMovies());
			foreach (var movie in expectedMovies) {
				Assert.That(actualMovies, Has.Member(movie));
			}
		}		
	}
}