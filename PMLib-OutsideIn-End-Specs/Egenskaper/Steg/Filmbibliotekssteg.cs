using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using PMLibOutsideInEnd;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PMLibOutsideInEndSpecs.Egenskaper.Steg
{
    [Binding]
    public class Filmbibliotekssteg
    {

        private MovieList _collection;
        private MovieListController _movieCollectionController;
        private IMovieListView _listView;
        private string _listning;

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

        [When(@"jag lägger till filmerna ""(.*)""")]
        public void NarJagLaggerTillFilmerna(string titlar)
        {
            IEnumerable<string> titelLista = titlar.Split(',');
            foreach (string titel in titelLista)
            {
                _movieCollectionController.Add(new Movie(titel));
            }
        }

        [Then(@"ska listan se ut så här:")]
        public void SaSkaListanSeUtSaHar(Table table)
        {
            IEnumerable<Movie> filmer = table.CreateSet<Movie>();
            string förväntatMeddelande = "";
            foreach (Movie movie in filmer)
            {
                förväntatMeddelande = förväntatMeddelande + movie.Titel + "\n";
            }
            _listning = _listView.View();
            Assert.That(_listning, Is.StringStarting(förväntatMeddelande));
        }

        [Then(@"meddelandet ""(.*)"" visas på skärmen")]
        public void SaMeddelandetVisasPaSkarmen(string förväntatMeddelande)
        {
            Assert.That(_listning, Is.StringEnding(förväntatMeddelande));
        }

    }
}