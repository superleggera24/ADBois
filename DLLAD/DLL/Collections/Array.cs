using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt door: Frans Orsel
    // Geen source gebruikt

    public static class RandArray<T>
    {
        // create random array vul met 300 iets
        public static T[] _RandomArray = new T[300];

        public static T[] RandomArray
        {
            get { return _RandomArray; } //get de random array
        }

        //initieer de array
        public static void InitiateArray(List<T> list, int size)
        {
            
            int count = 0; //houd positie in de array bij.
            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (T player in list)
            {
                _RandomArray[count] = player; //weergeef speler
                count++;
            }
        }
    }
}
