using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandArray<T> where T : IComparable
    {
        public static int[] _RandomArray;
        public static int[] RandomArray
        {
            get { return _RandomArray; }
        }
        public static void InitiateArray(int[] Numbers)
        {
            _RandomArray = new int[1000];
            int count = 0;

            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (int number in Numbers)
            {
                _RandomArray[count] = Numbers[count];
                count++;
            }
        }
    }
}
