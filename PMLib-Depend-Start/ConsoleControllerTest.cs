using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PMLibDependStart
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
			// TODO
		}

		[Test]
		public void ShouldListAllMoviesWithTotalCount()
		{
			_movieList.Add(new Movie(MovieNameJaws));
			_movieList.Add(new Movie(MovieNameTheShining));

			_controller.Execute(ConsoleController.LIST_ACTION);

			var outputLines = _consoleStub.GetRecordedOutput();
			Assert.That(outputLines[2], Is.EqualTo(String.Format(ConsoleController.FOOTER, 2)));
			Assert.That(outputLines.Contains(MovieNameJaws));
			Assert.That(outputLines.Contains(MovieNameTheShining));
		}


		/// <summary>
		/// Stub of console given canned answers. Can be queried for output.
		/// </summary>
		private class ConsoleRecorder : IConsole
		{

			public void PrintLine(String content)
			{
				// TODO
			}

			internal List<String> GetRecordedOutput()
			{
				// TODO
				return null;
			}

		}
	}
}