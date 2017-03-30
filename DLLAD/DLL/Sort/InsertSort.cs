using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class InsertSort<T> where T : IComparable
    {
        public static T[] InsertSortArrayList(T[] arr)
        {
            T z;
            for (var i = 1; i < arr.Length; i++)
            {
                z = arr[i];
                while ((i - 1 >= 0) && (z.CompareTo(arr[i - 1]) < 0))
                {
                    arr[i] = arr[i - 1];
                    i--;
                }
                arr[i] = z;
            }
            return arr;
        }
    }
}
