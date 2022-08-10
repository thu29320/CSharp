

namespace Book.Views
{
    using System;
    using Models;
    using Framework;
    internal class BookListView
    {
        protected Book[] Model;


        public BookListView(Book[] model)
        {
            Model = model;
        }
        public void Render()
        {
            if(Model.Length==0)
            {
                ViewHelp.ShowColor("No Book Found.");
            }
            else
            {
                ViewHelp.ShowColor("The book list: ", ConsoleColor.Green);
                for(int i = 0; i < Model.Length; i++)
                {
                    ViewHelp.Show_Color($"[{Model[i].Id}]", ConsoleColor.Green);
                    ViewHelp.ShowColor($"[{ Model[i].Title}]", Model[i].Reading ? ConsoleColor.Cyan : ConsoleColor.White);
                   
                }
            }
        }
    }
}
