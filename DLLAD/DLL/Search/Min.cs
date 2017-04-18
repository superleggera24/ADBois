using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public static class Min<T> where T : IComparable
    {
        // Deze methode brengt de speler met de laagste Highscore terug.
        public static T Search(T[] array)
        {
            T min = array[0];
            for (int i = 0; i < array.Length - 1; i++) //loop door de gehele array
            {
                if (array[i].CompareTo(min) < 0) // alleen als het huidige punt lager is dan de huidige min, verander de min naar de huidige.
                    min = array[i];

            }
            return min;
        }


    }
}
