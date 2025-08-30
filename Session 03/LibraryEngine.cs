using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class LibraryEngine
    {
        //Take a User Defined Delegate
        public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        //Take a Build-In Delegate
        public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
