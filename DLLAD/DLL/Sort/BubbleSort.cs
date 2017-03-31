using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AD.Sort
{
    public static class BubbleSort<T> where T : IComparable
    {
        // maak generic arraylist 
        public static T[] Sort(T[] array)
        {
            //loop door array, i
            for (var i = 0; i < array.Length; i++)
            {
                //loop door array -1, j
                for (var j = 0; j < array.Length - 1; j++)
                {
                    //wanneer de waarde groter is dan de volgende waarde word hieronder dmv swapclass.cs de waardes omgedraaid
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp;
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        //swapclass.Swap<T>(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }
    }
}
