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

            //--------------------------------- Vedio 02 ---------------------------------
            #region Example 02
            //int[] Numbers = { 7, 5, 6, 3, 2, 1, 8, 9, 4 };

            ////SortingAlgorithms.BubbleSort(Numbers);
            ////SortingAlgorithms.BubbleSort(Numbers, SortingTypes.CompareGreater);

            //SortingTypesFuncDelegate sortingTypes = SortingTypes.CompareLess;
            //SortingAlgorithms.BubbleSort(Numbers, sortingTypes);

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

        }
    }
}
