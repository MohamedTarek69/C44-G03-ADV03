namespace Session_03
{
    internal class Program
    {
        public delegate int StringFuncDelegate(string s);
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
            ////int x = StringFunctions.GetCountOfUpperCaseChar(); // invalid
            //// 1. Declare Reference From Delegate
            //StringFuncDelegate stringFunc;

            //// 2. Initialize Reference From Delegate[Pointer To Function]
            //stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);

            //stringFunc = StringFunctions.GetCountOfUpperCaseChar;
            //stringFunc = StringFunctions.GetCountOfLowerCaseChar;

            ////stringFunc = StringFunctions.GetCountOfUpperCaseChar;
            ////stringFunc += StringFunctions.GetCountOfLowerCaseChar;
            ////stringFunc -= StringFunctions.GetCountOfLowerCaseChar;
            ////stringFunc -= StringFunctions.GetCountOfUpperCaseChar;

            ////3.Use Delegate Reference[Call Method]
            //int Result = stringFunc.Invoke("RouTe");
            //Result = stringFunc("MoHaMeD TaReK");
            //Console.WriteLine(Result);

            #endregion

            //--------------------------------- Vedio 02/03  ---------------------------------
            #region Example 02
            //int[] Numbers = { 7, 5, 6, 3, 2, 1, 8, 9, 4 };
            ////SortingAlgorithms.BubbleSort(Numbers);
            //SortingAlgorithms<int>.BubbleSort(Numbers, SortingTypes.SortAsc);

            ////SortingTypesFuncDelegate<int> sortingTypes = SortingTypes.SortDesc;
            ////SortingAlgorithms<int>.BubbleSort(Numbers, sortingTypes);

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] Names = { "Omar", "Moahmed", "Amr", "Salma" };

            ////SortingAlgorithms<string>.BubbleSort(Names, SortingTypes.SortAsc);

            //SortingTypesFuncDelegate<string , string , bool > sortingTypes = SortingTypes.SortDesc;

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

            //FilterFuncDelegate<int> filter = FilterOfLists.CheckEven;
            //List<int> EvenNumbers = FilterLists.FindElements(Numbers, filter);

            //List<int> Divisble07Numbers = FilterLists.FindElements(Numbers, FilterOfLists.DivisibleBy7);
            //List<int> Divisble10Numbers = FilterLists.FindElements(Numbers, FilterOfLists.DivisibleBy10);

            //foreach (int num in Divisble10Numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            //List<string> Names = new List<string>() { "Ahmed", "Aya", "Khalid", "Rawan", "Amr", "Heba" };

            //List<string> Names = ["Ahmed", "Aya", "Khalid", "Rawan", "Amr", "Heba"];
            //List<string> FilterName = FilterLists.FindElements(Names, FilterOfLists.CheckLengthLessThanFour);
            //List<string> FilterName02 = FilterLists.FindElements(Names, FilterOfLists.CheckLengthMoreThanFour);

            //foreach (string s in FilterName02)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion


        }
    }
}
