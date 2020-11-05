using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms_sample2.Linq
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfRelease { get; set; }
    }

    public class Books
    {

        public static List<Book> GetBooks()
        {
            List<Book> list = new List<Book>();
            list.Add(new Book
            {
                ID = "001",
                Title = "Programming in C#",
                Price = 634.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Book
            {
                ID = "002",
                Title = "Learn Java in 30 days",
                Price = 250.76m,
                DateOfRelease = Convert.ToDateTime("2011-08-15")
            });

            list.Add(new Book
            {
                ID = "003",
                Title = "Programming in ASP.Net 4.0",
                Price = 700.00m,
                DateOfRelease = Convert.ToDateTime("2011-02-05")
            });

            list.Add(new Book
            {
                ID = "004",
                Title = "VB.Net Made Easy",
                Price = 500.99m,
                DateOfRelease = Convert.ToDateTime("2011-12-31")
            });

            list.Add(new Book
            {
                ID = "005",
                Title = "Programming in C",
                Price = 314.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Book
            {
                ID = "006",
                Title = "Programming in C++",
                Price = 456.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Book
            {
                ID = "007",
                Title = "Datebase Developement",
                Price = 1000.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            return list;
        }
    }
}