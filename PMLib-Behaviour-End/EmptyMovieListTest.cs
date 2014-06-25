/*
 * PM Library (TDD training project)
 * Joakim Holm & Måns Sandström
 */

using NUnit.Framework;

namespace PMLibBehaviorEnd
{
	[TestFixture]
	public class EmptyMovieListTest
	{
		private MovieList _emptyMovieList;
		
		[SetUp]
		public void SetUp()
		{
			_emptyMovieList = new MovieList();
		}
		
		[Test]
		public void ShouldBeEmpty()
		{
			Assert.That(_emptyMovieList.IsEmpty(), Is.True);
		}

		[Test]
		public void ShouldContainNoMovies()
		{
			Assert.That(_emptyMovieList.NumberOfMovies(), Is.EqualTo(0));
		}
		
		[Test]
		public void CanAddMovie()
		{
			_emptyMovieList.Add(new Movie("Jaws"));
			Assert.That(_emptyMovieList.NumberOfMovies(), Is.EqualTo(1));
		}
		
		[Test]
		public void ShouldBeIterableButNoElements()
		{
			Assert.That(_emptyMovieList.GetEnumerator().MoveNext(), Is.False);
		}
	}
}
