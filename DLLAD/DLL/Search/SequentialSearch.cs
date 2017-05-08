using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Search
{
    // Klasse gemaakt door: Frans Orsel
    // Source: Datastructures & Algorithms Using C# door Michael McMillan

    public static class SequentialSearch<T> where T : IComparable
    {
        // Dit is de methode voor de sequentialsearch methode. er wordt een generieke array en een nummer meegestuurd
        public static int SeqSearch(T[] random, int number)
        {
            int place = 0;
            // deze search blijft door de array loopen tot hij er door is.
            for(int count = 0; count < random.Length-1; count++)
            {
                // alleen als het nummer gelijk staat aan de huidige plaats van de array, veranderd place in de huidige plaats van de array.
                if(random[count].Equals(number))
                {
                    place = count;
                }
            }
            return place;
        }
    }
}
