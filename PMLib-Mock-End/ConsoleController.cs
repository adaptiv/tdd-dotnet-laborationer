using System;

namespace PMLibMockEnd
{
	public class ConsoleController
	{
		public const String ListAction = "list";
		public const String Footer = "Antal filmer: {0} st";
		public const String MessageEmptyMovieCollection = "Det finns inga filmer i samlingen.";

		private readonly MovieList _movieList;
		private readonly IConsole _console;

		/// <summary>
		/// Creates instance with a console view to handle I/O and a domain model in the form of
		/// a container for movies.
		/// </summary>
		/// <param name="consoleToUse">text-based console for I/O</param>
		/// <param name="movieList">a container for movies</param>
		public ConsoleController(IConsole consoleToUse, MovieList movieList)
		{
			this._movieList = movieList;
			_console = consoleToUse;
		}

		/// <summary>
		/// Executes given command on the model.
		/// </summary>
		/// <param name="command">the command to execute</param>
		public void Execute(String command)
		{
			// NOTE Perhaps Command pattern will be useful later?
			if (ListAction == command)
			{
				ProcessListCmd();
			}
		}

		private void ProcessListCmd()
		{
			if (_movieList.IsEmpty())
			{
				PrintMessage(MessageEmptyMovieCollection);
			}
			else
			{
				PrintMovieList();
				PrintFooter();
			}
		}

		private void PrintMessage(String message)
		{
			_console.PrintLine(message);
		}

		private void PrintMovieList()
		{
			foreach (var movie in _movieList)
			{
				_console.PrintLine(movie.Title);
			}
		}

		private void PrintFooter()
		{
			_console.PrintLine(String.Format(Footer, _movieList.NumberOfMovies()));
		}
	}
}