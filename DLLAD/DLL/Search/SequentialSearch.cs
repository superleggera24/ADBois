using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public static class SequentialSearch<T> where T : IComparable
    {
        public static int SeqSearch(T[] random, int number)
        {
            int place = 0;
            for(int count = 0; count < random.Length-1; count++)
            {
                if(random[count].CompareTo(number) == 0)
                {
                    place = count;
                }
            }
            return place;
        }
    }
}
