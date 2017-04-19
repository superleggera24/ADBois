using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    public class BinarySearch<T> where T : IComparable
    {
        public static int binSearch(T[] arr, int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            mid = -1;

            // zolang lowerbound kleiner is of gelijk aan de upperbound (die 1 minder dan de lengte van de array is)
            // loopt de functie verder.
            while(lowerBound <= upperBound)
            {
                // om het midden van de array te kunnen gebruiken voor het zoeken moet hij telkens opnieuw het midden opnieuw
                // berekenen. Vervolgens kijkt hij of het midden gelijk is aan het te zoeken getal, waarna hij dat returnt
                // of dat het midden hoger is dan het te zoeken getal, waarna upperbound met 1 verlaagt wordt.
                mid = (upperBound + lowerBound) / 2;
                
                if (arr[mid].CompareTo(value) == 0)
                {
                    return mid;
                }
                else if (arr[mid].CompareTo(value) > 0)
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid + 1;
                }
            }
            return mid;
        }
    }
}
