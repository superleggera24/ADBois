using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public static class SequentialSearch
    {
        public static int SeqSearch(int[] random, int number)
        {
            int place = 0;
            int count = 0;
            foreach(int no in random)
            {
                if(no == number)
                {
                    place = count;
                }
                count++;
            }
            return place;
        }
    }
}
