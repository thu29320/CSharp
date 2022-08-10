

namespace Book.Controllers
{
    using System;
    using Models;
    using Views;
    class BookControler//lop dieu khien giup ket noi du lieu voi hien thi
    {
        public void Single(int id)
        {
            Book model = new Book
            {
                Id = 1,
                Title = "Toi thay hoa vang tren co xanh",
                Author = "Nguyen Nhat Anh",
                Publisher = "Kim Dong",
                Year = 2012,
                Type = "Thieu Nhi",
                Description = "Cuon sach la nhung ki niem tho au cua moi dua tre vung que, em dem ko the nao quen",
                Rating = 5,
                Reading=true

            };
            //khoi tao view
            BookSingleView view = new BookSingleView(model);
            //goi ham Render() de hien thi thong tin
            view.Render();

        }
        public void Create()
        {
            BookCreateView view = new BookCreateView();
            view.Render();
        }
        public void Update()
        {
            var model = new Book();
            var view = new BookUpdateView(model);
            view.Render();
        }
        public void List()
        {
            Book[] model = new Book[]
            {
                new Book{Id=1,Title="A new book 1"},
                new Book{Id=2,Title="A new book 2"},
                new Book{Id=3,Title="A new book 3"},
                new Book{Id=4,Title="A new book 4"},
                new Book{Id=5,Title="A new book 5"},
                new Book{Id=6,Title="A new book 6"},
            };
            BookListView view = new BookListView(model);
            view.Render();
        }
    }
}
