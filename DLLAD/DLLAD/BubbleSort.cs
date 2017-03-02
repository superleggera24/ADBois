using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLAD
{
    public static class Bubblesort
    {
        public static void BubbleSortArrayList<T>(this T[] arr) where T : IComparable<T>
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        swapclass.Swap<T>(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
