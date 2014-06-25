using Moq;
using NUnit.Framework;

namespace PMLibMockEnd
{
	[TestFixture]
	public class ConsoleControllerWithNoMoviesTest
	{
		private Mock<IConsole> _console;
		private Mock<MovieList> _movieList;
		private ConsoleController _controller;

		[SetUp]
		public void SetupController()
		{
			_console = new Mock<IConsole>();
			_movieList = new Mock<MovieList>();
			_controller = new ConsoleController(_console.Object, _movieList.Object);
		}

		[Test]
		public void ShouldIndicateIfListingEmptyMovieList()
		{
			_movieList.Setup(m => m.IsEmpty()).Returns(true);
			_controller.Execute(ConsoleController.ListAction);
			_console.Verify(c => c.PrintLine(ConsoleController.MessageEmptyMovieCollection));
		}
		
	}
}