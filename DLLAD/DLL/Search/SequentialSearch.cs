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
            int count = 0;
            foreach(T no in random)
            {
                if(random[count].CompareTo(number) < 0)
                {
                    place = count;
                }
                count++;
            }
            return place;
        }
    }
}
