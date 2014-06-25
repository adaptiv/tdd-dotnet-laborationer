using System;

namespace PMLibRefactorStart
{
	public class Movie : IComparable<Movie>
	{
		private readonly string _title;
		private readonly string _directorName;
		private readonly int _minutes;
		private readonly string _rating;

		public Movie(string title, string directorName, int minutes, string rating)
		{
			this._title = title;
			this._directorName = directorName;
			this._minutes = minutes;
			this._rating = rating;
		}

		public string Rating
		{
			get { return _rating; }
		}

		public int Length
		{
			get { return _minutes; }
		}

		public string Director
		{
			get { return _directorName; }
		}

		public string Title
		{
			get { return _title; }
		}

		public int CompareTo(Movie other)
		{
			return String.Compare(_title, other.Title, System.StringComparison.Ordinal);
		}
	}
}