
namespace Book.Views
{
    using System;
    using Models;
    using Framework;
    using static System.Console;
    class BookUpdateView
    {
        protected Book Model;
        public BookUpdateView(Book model)
        {
            Model = model;
        }
        public void Render()
        {
            ViewHelp.ShowColor("Update book information");//ShowColor: Console.WriteLine
            var title = ViewHelp.InputString("Title", Model.Title);
            var author = ViewHelp.InputString("Author", Model.Author);
            var publisher = ViewHelp.InputString("Publisher", Model.Publisher);
            var type = ViewHelp.InputString("Type", Model.Type);
            var year = ViewHelp.InputInt("Year", Model.Year);
            var rating = ViewHelp.InputInt("Rating", Model.Rating);
            var reading = ViewHelp.InputBool("Reading", Model.Reading);
            var description = ViewHelp.InputString("Description", Model.Description);
            var dile = ViewHelp.InputString("File", Model.File);
        }
    }
}
