using System;

namespace PMLibDependEnd
{
	/// <summary>
	/// Interface for any type of text-based user interface
	/// </summary>
	public interface IConsole
	{
		/// <summary>
		/// Prints given line to the console output.
		/// </summary>
		/// <param name="lineContent">text to print</param>
		void PrintLine(String lineContent);


	}
}