using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public static class Min<T> where T : IComparable
    {
        public static T Search(T[] array)
        {
            T min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo (min) < 0)
                    min = array[i];
            }
            return min;
        }
    }
}
