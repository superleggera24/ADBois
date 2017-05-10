using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class SmartBubbleSort<T> where T : IComparable
    {
        // Klasse gemaakt door: Frans Orsel
        
        // maak generic arraylist 
        public static T[] Sort(T[] array)
        {
            bool swap_flag = true;
            int passnum = array.Length;

            //loop door array, i
            for (var i = 0; (i < (passnum)) && swap_flag; i++)
            {
                swap_flag = false;
                //loop door array -1, j
                for (var j = 0; j < array.Length - 1; j++)
                {
                    //wanneer de waarde groter is dan de volgende waarde word hieronder de waardes omgedraaid
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp;
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap_flag = true;
                    }
                }
            }
            return array;
        }
    }
}

