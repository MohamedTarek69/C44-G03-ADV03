using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public delegate string BookFunctionDelegate(Book B);
    internal class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            if (b is not null)
            {
                return b.Title;
            }
            return "N/A";
        }
        public static string GetAuthor(Book b)
        {
            if (b is not null)
            {  
                return b.Author; 
            }
            return "N/A";
        }
        public static string GetPrice(Book B)
        {
            if(B is not null)
            {
                return B.Price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
            return "N/A";
        }
        // Anonymus Function + returns User Defined Delegate  
        public static BookFunctionDelegate GetISBN()
        {
            return delegate (Book b) { return b is not null ? b.ISBN.ToString() : "N/A"; };
        }
        // Lambda Expression + returns Build-In Delegate  
        public static Func<Book, string> GetPublicationDate()
        {
            return b => b is not null ? b.PublicationDate.ToShortDateString() : "N/A"; ;
        }
    }
}
