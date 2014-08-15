namespace PMLibOutsideInEnd
{
    public class MovieListController
    {
        public const string EmptyListFooter = "There are no movies in the collection";

        private readonly MovieList _collection;
	    private IMovieListView _listView;

        public MovieListController(MovieList collection)
        {
		    _collection = collection;
        }

        public void SetListView(IMovieListView listView)
        {
            _listView = listView;
        }

        public void List()
        {
            foreach (Movie movie in _collection)
            {
                _listView.AddListEntry(movie);
            }
            _listView.AddFooter(_collection.Size());
        }

        public void Add(Movie movie)
        {
            _collection.Add(movie);
        }
    }
}