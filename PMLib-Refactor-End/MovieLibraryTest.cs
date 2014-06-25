using NUnit.Framework;

namespace PMLibRefactorEnd
{
	[TestFixture]
	public class MovieLibraryTest
	{
		private const int FirstMovieIndex = 1;
		private MovieLibrary _movieLibrary;

		[TestFixtureSetUp]
		public void CreateLibrary()
		{
			_movieLibrary = new MovieLibrary();
			_movieLibrary.Add(new Movie("Jaws", "Steven Spielberg", 115, "R"));
			_movieLibrary.Add(new Movie("E.T.", "Steven Spielberg", 122, "PG"));
		}

		[Test]
		public void ShouldProvideAllMoviesInLibrary()
		{
			Assert.That(_movieLibrary.RenderMovieLibrary()[FirstMovieIndex], Is.EqualTo("Jaws by Steven Spielberg, 115 mins, rated R"));
		}

		[Test]
		public void ShouldProvideAllMoviesInLibrarySortedByTitle()
		{
			Assert.That(_movieLibrary.RenderLibrarySortedByTitle()[FirstMovieIndex], Is.EqualTo("E.T. by Steven Spielberg, 122 mins, rated PG"));
		}
	}
}