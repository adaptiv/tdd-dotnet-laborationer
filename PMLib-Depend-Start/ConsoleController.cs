using System;

namespace PMLibDependStart
{
	public class ConsoleController
	{
		public static readonly String LIST_ACTION = "list";
		public static readonly String FOOTER = "Antal filmer: {0} st";

		/// <summary>
		/// Creates instance with a console view to handle I/O and a domain model in the form of
		/// a container for movies.
		/// </summary>
		/// <param name="consoleToUse">text-based console for I/O</param>
		/// <param name="movies">a container for movies</param>
		public ConsoleController(IConsole consoleToUse, MovieList movies)
		{
			// TODO
		}

		/// <summary>
		/// Executes given command on the model.
		/// </summary>
		/// <param name="command">the command with parameters as an array, first element is the actual command</param>
		public void Execute(String command)
		{
			// TODO
		}

	}
}