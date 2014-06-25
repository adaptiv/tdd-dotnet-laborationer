using System;

namespace PMLibMockStart
{
	public class ConsoleController
	{
		public static readonly String LIST_ACTION = "list";
		public static readonly String FOOTER = "Antal filmer: {0} st";
		public static readonly String MESSAGE_EMPTY_MOVIE_COLLECTION = "Det finns inga filmer i samlingen.";

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
			// TODO
		}

	}
}