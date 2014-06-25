using System;
using Moq;
using NUnit.Framework;

namespace PMLibMockEnd
{
	[TestFixture]
	public class ConsoleControllerWithMoviesTest
	{
	    private const string MovieNameJaws = "Jaws";
	    private const string MovieNameTheShining = "The Shining";

	    private Mock<IConsole> _console;
		private MovieList _movieList;
		private ConsoleController _controller;

		[SetUp]
		public void SetupController()
		{
			_movieList = new MovieList();
			_movieList.Add(new Movie(MovieNameJaws));
			_movieList.Add(new Movie(MovieNameTheShining));
			_console = new Mock<IConsole>();
			_controller = new ConsoleController(_console.Object, _movieList);
		}

		[Test]
		public void ShouldListAllMovieWithMovieCount()
		{
			_controller.Execute(ConsoleController.ListAction);
			_console.Verify(c => c.PrintLine(MovieNameJaws));
			_console.Verify(c => c.PrintLine(MovieNameTheShining));
			_console.Verify(c => c.PrintLine(String.Format(ConsoleController.Footer, 2)));
		}

	}
}