using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandArray<T>
    {
        public static T[] _RandomArray = new T[300];
        public static T[] RandomArray
        {
            get { return _RandomArray; }
        }
        public static void InitiateArray(List<T> list, int size)
        {
            
            int count = 0;
            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (T player in list)
            {
                _RandomArray[count] = player;
                count++;
            }
        }
    }
}
