namespace Session_03
{
    internal class Program
    {
        //public delegate int StringFuncDelegate(string s);
        // New Delegate [Class]
        // Ref From Delegate can Refer to Function or More [pointer to Function]
        // this function can be static Function [Class member function]
        // this function can be non-static Function [Object member function]
        // this function must be wtih same signature of delegate
        // Regardless Function Naming [Method name - Paramter Namr]
        // Regardless Access Modfire
        static void Main(string[] args)
        {
            //--------------------------------- Vedio 01 ---------------------------------
            #region Example 01
            //int x = StringFunctions.GetCountOfUpperCaseChar(); // invalid
            // 1. Declare Reference From Delegate
            //StringFuncDelegate stringFunc;

            // 2. Initialize Reference From Delegate[Pointer To Function]
            //stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);

            //Func<string , int> func = StringFunctions.GetCountOfUpperCaseChar;
            //int Result = func.Invoke("RouTe");
            //Result = func("MoHaMeD TaReK");
            //Console.WriteLine(Result);

            //Func<string , int> func01 = StringFunctions.GetCountOfLowerCaseChar;
            //int Result01 = func01.Invoke("RouTe");
            //Result01 = func01("MoHaMeD TaReK");
            //Console.WriteLine(Result01);

            //stringFunc = StringFunctions.GetCountOfUpperCaseChar;
            //stringFunc = StringFunctions.GetCountOfLowerCaseChar;

            //stringFunc = StringFunctions.GetCountOfUpperCaseChar;
            //stringFunc += StringFunctions.GetCountOfLowerCaseChar;
            //stringFunc -= StringFunctions.GetCountOfLowerCaseChar;
            //stringFunc -= StringFunctions.GetCountOfUpperCaseChar;

            //3.Use Delegate Reference[Call Method]
            //int Result = stringFunc.Invoke("RouTe");
            //Result = stringFunc("MoHaMeD TaReK");
            //Console.WriteLine(Result);




            #endregion

            //--------------------------------- Vedio 02/03  ---------------------------------
            #region Example 02
            //int[] Numbers = { 7, 5, 6, 3, 2, 1, 8, 9, 4 };
            //SortingAlgorithms.BubbleSort(Numbers);
            //SortingAlgorithms<int>.BubbleSort(Numbers, SortingTypes.SortAsc);

            //Func<int,int,bool> sortingTypes = SortingTypes.SortDesc;
            //SortingAlgorithms<int>.BubbleSort(Numbers, sortingTypes);

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] Names = { "Omar", "Moahmed", "Amr", "Salma" };

            //SortingAlgorithms<string>.BubbleSort(Names, SortingTypes.SortAsc);

            //Func<string, string, bool> sortingTypes = SortingTypes.SortDesc;

            //SortingAlgorithms<string>.BubbleSort(Names, sortingTypes);

            //foreach (string s in Names)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            //--------------------------------- Vedio 04/05 ---------------------------------
            #region Example 03
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = FilterLists.FindElements(Numbers, FilterOfLists.CheckOdd);

            //Predicate<int> filter = FilterOfLists.CheckEven;
            //List<int> EvenNumbers = FilterLists.FindElements(Numbers, filter);

            //List<int> Divisble07Numbers = FilterLists.FindElements(Numbers, FilterOfLists.DivisibleBy7);
            //List<int> Divisble10Numbers = FilterLists.FindElements(Numbers, FilterOfLists.DivisibleBy10);

            //foreach (int num in EvenNumbers)
            //{
            //    Console.Write($"{num} ");
            //}

            ////List<string> Names = new List<string>() { "Ahmed", "Aya", "Khalid", "Rawan", "Amr", "Heba" };

            //List<string> Names = ["Ahmed", "Aya", "Khalid", "Rawan", "Amr", "Heba"];
            //List<string> FilterName = FilterLists.FindElements(Names, FilterOfLists.CheckLengthLessThanFour);
            //List<string> FilterName02 = FilterLists.FindElements(Names, FilterOfLists.CheckLengthMoreThanFour);

            //foreach (string s in FilterName02)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            //--------------------------------- Vedio 06 ---------------------------------
            #region Built in Delegate

            //Action<string> action02 = TestBuiltInDelegate.Print;
            //action02.Invoke("Mohamed");
            //action02("Mohamed");

            //Action action = TestBuiltInDelegate.Print;
            //action.Invoke();
            //action();

            //Func<int, string> func = TestBuiltInDelegate.Casting;
            //string Number = func.Invoke(42);
            //Number = func(42);

            //Console.WriteLine(Number);

            //Predicate<int> predicate = TestBuiltInDelegate.CheckPostive;
            //bool flag = predicate.Invoke(10);
            //flag = predicate(20);

            //Console.WriteLine(flag);

            #endregion

            //--------------------------------- Vedio 07 ---------------------------------
            #region Anonymous Method

            //Action<string> action02 = delegate (string name) { Console.WriteLine($"Hello {name}"); };
            //action02.Invoke("Mohamed");
            //action02("Mohamed");

            //Action action = delegate () { Console.WriteLine("Hello Route"); };
            //action.Invoke();
            //action();

            //Func<int, string> func = delegate (int number) { return number.ToString(); };
            //string Number = func.Invoke(42);
            //Number = func(42);

            //Console.WriteLine(Number);

            //Predicate<int> predicate = delegate (int number) { return number > 0; };
            //bool flag = predicate.Invoke(10);
            //flag = predicate(20);

            //Console.WriteLine(flag);

            #endregion

            #region Lambda Expression

            Action<string> action02 = name => Console.WriteLine($"Hello {name}"); 
            action02.Invoke("Mohamed");
            action02("Mohamed");

            Action action = () => Console.WriteLine("Hello Route"); 
            action.Invoke();
            action();

            Func<int, string> func = number =>number.ToString(); 
            string Number = func.Invoke(42);
            Number = func(42);

            Console.WriteLine(Number);

            Predicate<int> predicate = number => number > 0;
            bool flag = predicate.Invoke(10);
            flag = predicate(20);

            Console.WriteLine(flag);

            #endregion

        }
    }
}
