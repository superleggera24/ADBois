using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    // Klasse gemaakt door: Manuel Weidijk
    // Source: Datastructures & Algorithms in C# door Michael McMillan

    public static class Max<T> where T : IComparable
    {
        // Deze methode brengt de speler met de hoogste Highscore terug.
        public static T Search(T[] array)
        {
            T max = array[0];
            for (int i = 0; i < array.Length; i++) // loop door de hele array
            {
                if (array[i].CompareTo(max) > 0) // alleen als het huidige punt hoger is dan de huidige max, verander de max naar de huidige.
                    max = array[i];
            }
            return max;
        }
    }
}
