using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandArray
    {
        public static int[] _RandomArray;
        public static int[] RandomArray
        {
            get { return _RandomArray; }
        }
        public static void InitiateArray()
        {
            _RandomArray = new int[1000];
            int maxRand = _RandomArray.Length * 2;
            int min = 0;
            Random randomNo = new Random();
            int count = 0;

            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (int number in _RandomArray)
            {
                _RandomArray[count] = randomNo.Next(min, maxRand);
                count++;
            }
        }
    }
}
