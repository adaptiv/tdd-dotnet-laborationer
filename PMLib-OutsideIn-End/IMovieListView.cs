namespace PMLibOutsideInEnd
{
    public interface IMovieListView
    {
        string View();

        void AddFooter(int numberOfMovies);
        void AddListEntry(Movie movie);
    }
}