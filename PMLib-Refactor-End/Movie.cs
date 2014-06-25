using System;
using System.Text;

namespace PMLibRefactorEnd
{
	public class Movie : IComparable<Movie>
	{

		private readonly string _directorName;
		private readonly int _lengthInMinutes;
		private readonly string _usRating;
		private readonly string _title;

		public Movie(string title, string directorName, int minutes, string rating)
		{
			this._title = title;
			this._directorName = directorName;
			this._lengthInMinutes = minutes;
			this._usRating = rating;
		}

		public int CompareTo(Movie other)
		{
			return String.Compare(_title, other._title, StringComparison.Ordinal);
		}

		public string Render()
		{
			var builder = new StringBuilder();
			builder.Append(_title);
			builder.Append(" by ");
			builder.Append(_directorName);
			builder.Append(", ");
			builder.Append(_lengthInMinutes);
			builder.Append(" mins, ");
			builder.Append("rated ");
			builder.Append(_usRating);
			return builder.ToString();
		}
	}
}