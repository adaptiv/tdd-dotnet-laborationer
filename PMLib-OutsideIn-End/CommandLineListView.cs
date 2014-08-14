using System;
using System.Collections.Generic;
using System.Text;

namespace PMLibOutsideInEnd
{
    public class CommandLineListView : IMovieListView
    {
        private const string NewLine = "\n";
	    public const string EmptyListFooter = "Ditt filmbibliotek är tomt.";
	    public const string SummaryFooter = "Antal filmer i samlingen {0}.";

	    private readonly List<String> _lines = new List<String>();

        public string View() {
		    var builder = new StringBuilder();
		    CombineLines(builder);
		    ClearContentForNextRequest();
            return builder.ToString().Trim();
	    }

        private void CombineLines(StringBuilder builder) {
		    foreach (string line in _lines) {
			    AddLine(builder, line);
		    }
	    }

        private void ClearContentForNextRequest()
        {
		    _lines.Clear();
	    }

	    private static void AddLine(StringBuilder builder, String line) {
		    builder.Append(line);
		    builder.Append(NewLine);
	    }

	    public void AddFooter(int numberOfMovies)
	    {
	        Boolean listEmpty = (numberOfMovies == 0);
	        _lines.Add(listEmpty ? EmptyListFooter : string.Format(SummaryFooter, numberOfMovies));
	    }
    }
}
