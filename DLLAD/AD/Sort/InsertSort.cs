using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public static class InsertSort
    {
        public static void InsertSortArrayList(this int[] arr)
        {
            int z;
            for (var i = 1; i < arr.Length; i++)
            {
                z = arr[i];
                while ((i - 1 >= 0) && (z < arr[i - 1]))
                {
                    arr[i] = arr[i - 1];
                    i--;
                }
                arr[i] = z;
            }
        }
    }
}
