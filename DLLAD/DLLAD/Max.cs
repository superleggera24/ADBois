using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLAD
{
    public static class Max
    {
        public static int MaxNumber(this int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    }
}
