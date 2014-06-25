using NUnit.Framework;

namespace PMLibRefactorEnd
{
	[TestFixture]
	public class MovieTest
	{
		[Test]
		public void ShouldBeRenderable()
		{
			var movie = new Movie("Jaws", "Steven Spielberg", 115, "R");
			Assert.That(movie.Render(), Is.EqualTo("Jaws by Steven Spielberg, 115 mins, rated R"));
		}
	}
}