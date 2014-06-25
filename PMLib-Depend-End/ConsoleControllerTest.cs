using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PMLibDependEnd
{
	[TestFixture]
	public class ConsoleControllerTest
	{
	    private const string MovieNameJaws = "Jaws";
	    private const string MovieNameTheShining = "The Shining";

	    private ConsoleController _controller;
		private ConsoleRecorder _consoleStub;
		private MovieList _movieList;

		[SetUp]
		public void SetupControllerWithMovieListAndConsole()
		{
			_consoleStub = new ConsoleRecorder();
			_movieList = new MovieList();
			_controller = new ConsoleController(_consoleStub, _movieList);
		}

		[Test]
		public void ShouldListAllMoviesWithTotalCount()
		{
			_movieList.Add(new Movie(MovieNameJaws));
			_movieList.Add(new Movie(MovieNameTheShining));

			_controller.Execute(ConsoleController.LIST_ACTION);

			var outputLines = _consoleStub.GetRecordedOutput();
			Assert.That(outputLines[2], Is.EqualTo(MovieListFooter(2)));
			Assert.That(outputLines.Contains(MovieNameJaws));
			Assert.That(outputLines.Contains(MovieNameTheShining));
		}
		[Test]
		public void ShouldIndicateIfListingEmptyMovieList()
		{
			_controller.Execute(ConsoleController.LIST_ACTION);

			var outputLines = _consoleStub.GetRecordedOutput();
			Assert.That(outputLines[0], Is.EqualTo(ConsoleController.MESSAGE_EMPTY_MOVIE_COLLECTION));
		}


		/// <summary>
		/// Stub of console given canned answers. Can be queried for output.
		/// </summary>
		private class ConsoleRecorder : IConsole
		{

			List<String> lines = new List<String>();
			public void PrintLine(String content)
			{
				lines.Add(content);
			}



			internal List<String> GetRecordedOutput()
			{
				return lines;
			}

		}

		private String MovieListFooter(int count)
		{
			return String.Format(ConsoleController.FOOTER, count);
		}

	}
}
