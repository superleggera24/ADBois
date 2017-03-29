using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandArray
    {
        public static Array[] _RandomArray;
        public static Array[] RandomArray
        {
            get { return _RandomArray; }
        }
        public static void InitiateArray(List<AD.Players> list, int size)
        {
            _RandomArray = new Array[1000];
            int count = 0;

            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (AD.Players player in list)
            {
                _RandomArray[player];
                count++;
            }
        }
    }
}
