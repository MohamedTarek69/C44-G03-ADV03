using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    //public delegate Tout SortingTypesFuncDelegate<T1,T2,out Tout>(T1 a, T2 b);
    internal static class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] Arr, Func<T,T,bool> sortingTypes)
        {
            if (Arr?.Length > 0 && sortingTypes is not null)
                for (int i = 0; i < Arr.Length - 1; i++)
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                        if (sortingTypes(Arr[j], Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 1]);
        }

        //public static void BubbleSortDesc(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //        for (int i = 0; i < Arr.Length; i++)
        //            for (int j = 0; j < Arr.Length - 1 - i; j++)
        //                if (Arr[j] < Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //}

        public static void SWAP(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
