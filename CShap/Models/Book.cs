using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class Book
    {
        private int _id = 1;
        public int Id// ko dc nhan gia tri nho hon 1
        {
            get { return _id; }
            set
            {
                if (_id >= 1)
                {
                    _id = value;
                }
            }
        }
        // ko dc nhan xau rong
        private string _title = "A new book";
        public string Title
        {
            get { return _title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _title = value;
                }
            }
        }
        private string _author = "Unknown Authow";
        public string Author
        {
            get { return _author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _author = value;
                }
            }
        }
        private string _publisher = "Unknown Publisher";
        public string Publisher
        {
            get { return _publisher; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _publisher = value;
                }
            }
        }
        private int _year = 2017;// ko nhan gia tri <1950
        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1950)
                {
                    _year = value;
                }
            }
        }
        private int _edition = 1; //ko nhan gia tri nho hon 1
        public int Edition
        {
            get { return _edition; }
            set
            {
                if (value >= 1950)
                {
                    _year = value;
                }
            }
        }

        public string Type { get; set; }//the loai sach
        public string Description { get; set; } = "A new book";
        private int _rating = 1;
        public int Rating//chi nhan gia tri tu 1 den 5
        {
            get { return _rating; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _rating = value;
                }
            }
        }
        public bool Reading { get; set; } = false;

        private string _file;
        public string File// chi chap nhan duong dan chinh xac den file chua sach pdf
        {
            get { return _file; }
            set
            {
                if (System.IO.File.Exists(value))//nhan duong dan dung
                {
                    _file = value;
                }
            }
        }
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); }//tra ve ten file

        }
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //    }
        //}
    }
}
