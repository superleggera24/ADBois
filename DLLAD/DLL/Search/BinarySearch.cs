using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public class BinarySearch<T> where T : IComparable
    {
        public static int binSearch(T[] arr, int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while(lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                
                if (arr[mid].CompareTo(value) == 0)
                {
                    return mid;
                }
                else if (arr[mid].CompareTo(value) > 0)
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid + 1;
                }
            }
            return -1;
        }
    }
}
