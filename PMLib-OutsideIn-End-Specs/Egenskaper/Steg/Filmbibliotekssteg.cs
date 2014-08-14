using NUnit.Framework;
using PMLibOutsideInEnd;
using TechTalk.SpecFlow;

namespace PMLibOutsideInEndSpecs.Egenskaper.Steg
{
    [Binding]
    public class Filmbibliotekssteg
    {

        private MovieList _collection;
        private MovieListController _movieCollectionController;
        private IMovieListView _listView;

        [BeforeScenario]
        public void SkapaTomFilmsamling()
        {
            _collection = new MovieList();
            _movieCollectionController = new MovieListController(_collection);

            _listView = new CommandLineListView();
            _movieCollectionController.SetListView(_listView);
        }

        [Given(@"att filmbiblioteket är tomt")]
        public void GivetAttFilmbiblioteketArTomt()
        {
            _collection.Clear();
        }

        [When(@"jag listar alla filmer")]
        public void NarJagListarAllaFilmer()
        {
            _movieCollectionController.List();
        }

        [Then(@"visas meddelandet ""(.*)"" på skärmen")]
        public void SaVisasMeddelandetPaSkarmen(string förväntatMeddelande)
        {
            Assert.That(_listView.View(), Is.EqualTo(förväntatMeddelande));
        }

    }
}