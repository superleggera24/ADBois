using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public static class Min
    {
        public static int MinNumber(this int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
    }
}
