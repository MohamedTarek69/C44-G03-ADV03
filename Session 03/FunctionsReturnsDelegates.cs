using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal static class FunctionsReturnsDelegates
    {
        public static Action DelegateAction()
        {
            return delegate () { Console.WriteLine("Hello Route"); };
        }

        public static Predicate<int> DelegatePredicate()
        {
            //return delegate (int x) { return x > 0; };
            return x => x > 0;
        }

        public static Func<char[], string> DelegateFunc()
        {
            //return delegate (char[] c) { return new string(c); };
            return c => new string(c);
        }

    }
}
