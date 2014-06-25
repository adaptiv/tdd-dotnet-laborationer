/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */

using NUnit.Framework;

namespace PMLibCodeStart
{
	/// <summary>
	/// Specifies design of MovieList.
	/// </summary>
	[TestFixture]
	public class MovieListTest
	{
		[Test]
		public void EmptyMovieListShouldBeEmpty()
		{
			var movieList = new MovieList();
			Assert.That(movieList.IsEmpty(), Is.True);
		}

		[Test]
		public void EmptyMovieListShouldContainNoMovies()
		{
			var movieList = new MovieList();
			Assert.That(movieList.NumberOfMovies(), Is.EqualTo(0));
		}
	}
}