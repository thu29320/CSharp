
namespace Book.Views

{
    using System;
    using static System.Console;
    using Models;
    using Framework;
    internal class BookSingleView    // class hien thi 1 cuon sach, chi su dung trong du an(internal)
    {
        protected Book Model; //bien Model lu thong tin cuon sach dang can hien thi

        public BookSingleView(Book model) //ham khoi tao, dc goi dau tien khi tao object
        {
            Model = model;//chuyen du lieu sang bien thanh vien de su dung trong toan class
        }

        /// <summary>
        /// thuc hien in thong tin ra man hinh console
        /// </summary>
        public void Render()
        {
             
            if (Model==null)//kiem tra xem object co du lieu ko
            {
                ViewHelp.ShowColor("NO BOOK FOUND.", ConsoleColor.Red);
            }
            ViewHelp.ShowColor("BOOK DETAIL INFORMATION",ConsoleColor.Green);

            //in thong tin cuon sach

            WriteLine($"Title:           {Model.Title}");
            WriteLine($"Author:          {Model.Author}");
            WriteLine($"Publisher:       {Model.Publisher}");
            WriteLine($"Year:            {Model.Year}");
            WriteLine($"Edition:         {Model.Edition}");
            WriteLine($"Type:            {Model.Type}");
            WriteLine($"Description:     {Model.Description}");
            WriteLine($"Rating:          {Model.Rating}");
            WriteLine($"Reading:         {Model.Reading}");
            WriteLine($"File:            {Model.File}");
            WriteLine($"FileName:        {Model.FileName}");
        }
        
    }
}
