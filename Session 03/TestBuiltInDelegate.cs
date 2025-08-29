using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal static class TestBuiltInDelegate
    {
        public static bool CheckPostive(int number) { return number > 0; }
        public static string Casting(int number) { return number.ToString(); }
        public static void Print() { Console.WriteLine("Hello Route"); }
        public static void Print(string name) { Console.WriteLine($"Hello {name}"); }

    }
}
