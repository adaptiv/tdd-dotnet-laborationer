/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */

using NUnit.Framework;

namespace PMLibCodeEnd
{
	/// <summary>
	/// Specifies design of MovieList.
	/// </summary>
	[TestFixture]
	public class MovieListTest
	{
		private static readonly Movie MovieJaws = new Movie("Jaws");
        private static readonly Movie MovieTheShining = new Movie("The Shining");
        private static readonly Movie MovieEt = new Movie("E.T.");
		
		[Test]
		public void EmptyMovieListShouldBeEmpty()
		{
			var emptyMovieList = new MovieList();
			Assert.That(emptyMovieList.IsEmpty(), Is.True);
		}

		[Test]
		public void EmptyMovieListShouldContainNoMovies()
		{
			var emptyMovieList = new MovieList();
			Assert.That(emptyMovieList.NumberOfMovies(), Is.EqualTo(0));
		}
		
		[Test]
		public void CanAddMovieToEmptyList()
		{
			var emptyMovieList = new MovieList();
			emptyMovieList.Add(MovieJaws);
			Assert.That(emptyMovieList.NumberOfMovies(), Is.EqualTo(1));
			Assert.That(emptyMovieList.IsEmpty(), Is.False);
		}
		
		[Test]
		public void ShouldIndicateNumberOfMovies()
		{
			var movieList = new MovieList();
			movieList.Add(MovieJaws);
			movieList.Add(MovieTheShining);
			movieList.Add(MovieEt);
			Assert.That(movieList.NumberOfMovies(), Is.EqualTo(3));
		}
	}
}