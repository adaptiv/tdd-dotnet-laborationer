using System;
using NUnit.Framework;

namespace PMLibOutsideInEnd
{
    class CommandLineListViewSpec
    {
        private CommandLineListView _view;

	    [SetUp]
	    public void CreateView() {
		    _view = new CommandLineListView();
	    }

	    [Test]
	    public void ShouldViewStandardFooterWhenEmpty() {
		    _view.AddFooter(0);
		    Assert.That(_view.View(), Is.EqualTo(CommandLineListView.EmptyListFooter));
	    }

	    [Test]
	    public void ShouldViewSummaryFooterListingMovies() {
		    _view.AddFooter(1);
		    string[] lines = _view.View().Split(new Char[] {'\n'} );
            Assert.That(lines[lines.Length - 1], Is.EqualTo(String.Format(CommandLineListView.SummaryFooter, 1)));
	    }
    }
}