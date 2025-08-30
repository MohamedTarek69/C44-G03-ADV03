namespace Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("C# Advanced", "Mohamed Tarek", 123, new DateTime(2020, 8, 25), 900.00m),
                new Book("C# OOP", "Ahmed Samy", 456, new DateTime(2021, 8, 26), 600.00m),
                new Book("C# Basics", "Philopater Naeem", 789, new DateTime(2022, 8, 27), 300.00m)
            };

            // User Defiend Delegate
            Console.WriteLine("---- Books Title ----");
            BookFunctionDelegate BookFunctionGetTitle = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, BookFunctionGetTitle);
            
            //Build-In Delegate  
            Console.WriteLine("\n---- Books Author ----");
            Func<Book, string> BookFunctionGetAuthor = BookFunctions.GetAuthor;
            LibraryEngine.ProcessBooks(books, BookFunctionGetAuthor);

            //Build-In Delegate  
            Console.WriteLine("\n---- Books Prices ----");
            Func<Book, string> BookFunctionGetPrice = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, BookFunctionGetPrice);

            // User Defiend Delegate
            Console.WriteLine("\n---- Books ISBN ----");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetISBN());

            //Build-In Delegate  
            Console.WriteLine("\n---- Books Publication Dates ----");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPublicationDate());

        }
    }
}
