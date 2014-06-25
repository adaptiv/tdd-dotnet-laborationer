using NUnit.Framework;

namespace PMLibRefactorStart
{
	[TestFixture]
	public class MovieLibraryTest
	{
		[Test]
		public void ShouldProvideAllMoviesInLibrary()
		{
			var jaws = new Movie("Jaws", "Steven Spielberg", 115, "R");
			var et = new Movie("E.T.", "Steven Spielberg", 122, "PG");

			var movieLibrary = new MovieLibrary();
			movieLibrary.Add(jaws);
			movieLibrary.Add(et);

			Assert.That(movieLibrary.GetMovies()[1], Is.EqualTo("Jaws by Steven Spielberg, 115 mins, rated R"));
		}

		[Test]
		public void ShouldProvideAllMoviesInLibrarySortedByTitle()
		{
			var jaws = new Movie("Jaws", "Steven Spielberg", 115, "R");
			var et = new Movie("E.T.", "Steven Spielberg", 122, "PG");

			var movieLibrary = new MovieLibrary();
			movieLibrary.Add(jaws);
			movieLibrary.Add(et);
			Assert.That(movieLibrary.GetMoviesByTitle()[1], Is.EqualTo("E.T. by Steven Spielberg, 122 mins, rated PG"));
		}
	}
}