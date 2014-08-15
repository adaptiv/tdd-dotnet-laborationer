using System.Linq;
using NUnit.Framework;
using Moq;

namespace PMLibOutsideInEnd
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

        [Test]
        public void ShouldAddMovieTitelsToViewWhenListing()
        {
            var movie = new Movie("Jaws");
            _collection.Add(movie);
            _controller.List();
            _listView.Verify(lw => lw.AddListEntry(movie));
            _listView.Verify(lw => lw.AddFooter(1));
        }

        [Test]
        public void ShouldAddMoviesToColletion()
        {
            var movie = new Movie("Jaws");
            _controller.Add(movie);
            Assert.That(_collection.Contains(movie));
        }
    }
}
