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
            _listView.AddFooter(_collection.Size());
        }
    }
}