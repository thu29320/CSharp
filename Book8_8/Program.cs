using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8_8
{
    class Book
    {
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public string producer { get; set; }
        public int yearPublishing { get; set; }
        public float price { get; set; }

        public Book()
        {

        }
        public Book(string name, string author, string producer, int year, float price)
        {
            this.bookName = name;
            this.bookAuthor = author;
            this.producer = producer;
            this.yearPublishing = year;
            this.price = price;
        }
        public virtual void Input()
        {
            Console.Write("Ten Sach:        ");
            bookName = Console.ReadLine();
            Console.Write("TacGia:   ");
            bookAuthor = Console.ReadLine();
            Console.Write("Nha Xuat Ban:         ");
            producer = Console.ReadLine();
            Console.Write("Nam phat hanh:     ");
            yearPublishing = int.Parse(Console.ReadLine());
            Console.Write("Gia Tien:        ");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("=====================================================");
        }
        public virtual void Output()
        {
            Console.WriteLine("Ten Sach:      " + bookName);
            Console.WriteLine("Tac Gia:       " + bookAuthor);
            Console.WriteLine("Nha Phat Hanh: " + producer);
            Console.WriteLine("Nam Phat Hanh: " + yearPublishing);
            Console.WriteLine("Gia Ca:        " + price);
            Console.WriteLine("=====================================================");
        }

    }
    class AptechBook : Book
    {
        public string language { get; set; }
        public int Semester { get; set; }

        public AptechBook()
        {

        }
        public AptechBook(string name, string author, string producer, int year, float price, string language, int semester) :
            base(name, author, producer, year, price)
        {
            this.language = language;
            this.Semester = semester;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Ngon ngu:        ");
            language = Console.ReadLine();

            Console.Write("Hoc Ki:     ");
            Semester = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Ngon Ngu:        " + language);
            Console.WriteLine("Hoc ki  :        " + Semester);
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            List<AptechBook> aptechBooks = new List<AptechBook>();
            int choice;
            do {
                ShowChoice();
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        AddBook(aptechBooks);
                      break;
                    case 2:
                        Display(aptechBooks);
                        break;
                    case 3:
                        break;
                    case 4:
                        SearchingByName(aptechBooks);
                        break;
                    case 5:
                        SearchingByAuthor(aptechBooks);
                        break;
                    case 6:
                        Console.WriteLine("Chuong trinh ket thuc.");
                        break;
                    default:
                        Console.WriteLine("lenh ko hop le");
                        break;
                }
                
                
            }

            while(choice != 6);
        }
        static void SearchingByName(List<AptechBook> aptechBooks)
        {
            Console.Write("Nhap ten sach can tim");
            string search = Console.ReadLine();
            for(int i=0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].bookName == search) {
                    aptechBooks[i].Output();
                }
            }
        }
        static void SearchingByAuthor(List<AptechBook> aptechBooks)
        {
            Console.Write("Nhap tac gia sach can tim");
            string search = Console.ReadLine();
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].bookAuthor == search)
                {
                    aptechBooks[i].Output();
                }
            }
        }
        static void AddBook(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap so sach can them: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i < n; i++)
            {
                AptechBook book = new AptechBook();
                book.Input();

                aptechBooks.Add(book);
            }
        }
        static void Display(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("So sach hien co la:  ");
            for(int i=0; i < aptechBooks.Count; i++)
            {
                aptechBooks[i].Output();
            }
        }
            public static void ShowChoice()
    {
        Console.WriteLine("Chon Chuc Nang: \n");
        Console.WriteLine("1. Nhap thong tin n cuon sach cua Aptech.");
        Console.WriteLine("2. Hien thi thong tin vua nhap");
        Console.WriteLine("3. Sap xep thong tin giam dan theo nam phat hanh.");
        Console.WriteLine("4. Tim kiem theo ten sach.");
        Console.WriteLine("5. Tim kiem theo ten tac gia.");
        Console.WriteLine("6.Thoat");
        Console.WriteLine("chon chuc nang: ");
    }

    } 
}
