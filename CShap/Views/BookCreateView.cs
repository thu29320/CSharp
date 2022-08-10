

namespace Book.Views
{
    using System;
    using Models;
    using Framework;
    using static System.Console;
    internal class BookCreateView
    {
        public  BookCreateView()
        {

        }
        //yeu cau nguoi dung nhap thong tin va luu lai thong tin do
        public void Render()
        {
            
           ViewHelp.ShowColor("Create a new book: ", ConsoleColor.Blue);

            var title = ViewHelp.InputString("Title");
            var author = ViewHelp.InputString("Author");
            var pulisher = ViewHelp.InputString("Publisher"); 
            var year = ViewHelp.InputInt("Year");
            var edition = ViewHelp.InputInt("Edition");
            var type = ViewHelp.InputString("Type");
            var description = ViewHelp.InputString("Description");
            var reading = ViewHelp.InputBool("Reading");
            var file = ViewHelp.InputString("File");
        }
        //chuyen mau chu cho Console.WriteLine
        
        //chuyen mau chu cho Console.Write
        

        
    }
}
