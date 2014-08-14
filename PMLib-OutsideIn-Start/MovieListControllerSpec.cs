using NUnit.Framework;
using Moq;

namespace PMLibOutsideInStart
{
    [TestFixture]
    public class MovieListControllerSpec
    {
        private MovieListController _controller;
	    private MovieList _collection;
	    private Mock<IMovieListView> _listView;

	    [SetUp]
	    public void CreateControllerWithEmptyCollection() {
		    _collection = new MovieList();
		    _controller = new MovieListController(_collection);

		    _listView = new Mock<IMovieListView>();
		    _controller.SetListView(_listView.Object);
	    }

	    [Test]
	    public void ShouldApplyListViewToCollectionWhenListing() {
		    _controller.List();
            _listView.Verify(lw => lw.AddFooter(0));
	    }
    }
}
