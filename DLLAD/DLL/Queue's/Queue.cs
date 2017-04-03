using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Queue_s
{
    public static class Queue<T> where T : IComparable
    {
        enum DigitType { ones = 1, tens = 10, hunderds = 100 }

        // maak generic arraylist 
        public static T[] Queue_s(T[] array)
        {
            for (int x = 0; x <= array.GetUpperBound(0); x++)
                Console.Write(array[x] + " ");
            return array;
        }
    }

}
