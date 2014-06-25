using System;

namespace PMLibDependEnd
{
	public class ConsoleController
	{
		public static readonly String LIST_ACTION = "list";
		public static readonly String FOOTER = "Antal filmer: {0} st";
		public static readonly String MESSAGE_EMPTY_MOVIE_COLLECTION = "Det finns inga filmer i samlingen.";

		private readonly MovieList _movieContainer;
		private readonly IConsole _console;

		/// <summary>
		/// Creates instance with a console view to handle I/O and a domain model in the form of
		/// a container for movies.
		/// </summary>
		/// <param name="consoleToUse">text-based console for I/O</param>
		/// <param name="movieList">a container for movies</param>
		public ConsoleController(IConsole consoleToUse, MovieList movieList)
		{
			_movieContainer = movieList;
			_console = consoleToUse;
		}

		/// <summary>
		/// Executes given command on the model.
		/// </summary>
		/// <param name="command">the command with parameters as an array, first element is the actual command</param>
		public void Execute(String command)
		{
			// NOTE Perhaps Command pattern will be useful later?
			if (LIST_ACTION == command)
			{
				ProcessListCmd();
			}
		}

		private void ProcessListCmd()
		{
			if (_movieContainer.IsEmpty())
			{
				PrintMessage(MESSAGE_EMPTY_MOVIE_COLLECTION);
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
			foreach (var movie in _movieContainer)
			{
				_console.PrintLine(movie.Title);

			}
		}

		private void PrintFooter()
		{
			_console.PrintLine(String.Format(FOOTER, _movieContainer.NumberOfMovies()));
		}

	}
}