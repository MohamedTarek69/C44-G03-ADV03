using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, int isbn, DateTime pubDate, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = pubDate;
            Price = price;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Date: {PublicationDate.ToShortDateString()}";
        }
    }
}
