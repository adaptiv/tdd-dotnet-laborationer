using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PMLibMockEnd
{
	[TestFixture]
	public class SmallMovieListTest
	{
		private static readonly Movie MovieTheShining = new Movie("The Shining");
		private static readonly Movie MovieJaws = new Movie("Jaws");
		private static readonly Movie MovieDeliverance = new Movie("Deliverance");

		private MovieList _movieList;

		[SetUp]
		public void SetUp()
		{
			_movieList = new MovieList();
			_movieList.Add(MovieDeliverance);
			_movieList.Add(MovieJaws);
			_movieList.Add(MovieTheShining);
		}

		[Test]
		public void ShouldIndicateNumberOfMovies()
		{
			Assert.That(_movieList.NumberOfMovies(), Is.EqualTo(3));
		}

		[Test]
		public void ShouldContainAllAddedMovies()
		{
			var expectedTitles = new List<string> {
			                                               	MovieDeliverance.Title,
			                                               	MovieJaws.Title,
			                                               	MovieTheShining.Title
			                                               };
			AssertAllMoviesPresent(expectedTitles);
		}

		private void AssertAllMoviesPresent(List<String> expectedTitles)
		{
			foreach (var movie in _movieList)
			{
				Assert.That(expectedTitles, Has.Member(movie.Title));
			}
		}
	}
}