using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public static class Max<T> where T : IComparable
    {
        public static T Search(T[] array)
        {
            T max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                    max = array[i];
            }
            return max;
        }
    }
}
