using NUnit.Framework;

namespace PMLibMockStart
{
	[TestFixture]
	public class EmptyMovieListTest
	{
		private MovieList _movieList;

		[SetUp]
		protected void SetUp()
		{
			_movieList = new MovieList();
		}

		[Test]
		public void ShouldContainNoMovies()
		{
			Assert.That(_movieList.NumberOfMovies(), Is.EqualTo(0));
		}
		[Test]
		public void ShouldBeEmpty()
		{
			Assert.That(_movieList.IsEmpty(), Is.True);
		}

		[Test]
		public void CanAddMovieToList()
		{
			var jaws = new Movie("Jaws");
			_movieList.Add(jaws);
			Assert.That(_movieList.NumberOfMovies(), Is.EqualTo(1));
		}

		[Test]
		public void ShouldBeIterable()
		{
			Assert.That(_movieList.GetEnumerator().MoveNext(), Is.False);
		}
	}
}