using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class SmartBubbleSort
    {
        // maak generic arraylist 
        public static void BubbleSortArrayList<T>(this T[] arr) where T : IComparable<T>
        {
            bool swap_flag = true;
            int passnum = arr.Length;

            //loop door array, i
            for (var i = 0; (i < (passnum)) && swap_flag; i++)
            {
                swap_flag = false;
                //loop door array -1, j
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    //wanneer de waarde groter is dan de volgende waarde word hieronder dmv swapclass.cs de waardes omgedraaid
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        swap_flag = true;
                        swapclass.Swap<T>(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}

