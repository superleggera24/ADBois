using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class BubbleSort
    {
        // maak generic arraylist 
        public static void BubbleSortArrayList<T>(this T[] arr) where T : IComparable<T>
        {
            //loop door array, i
            for (var i = 0; i < arr.Length; i++)
            {
                //loop door array -1, j
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    //wanneer de waarde groter is dan de volgende waarde word hieronder dmv swapclass.cs de waardes omgedraaid
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        swapclass.Swap<T>(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
