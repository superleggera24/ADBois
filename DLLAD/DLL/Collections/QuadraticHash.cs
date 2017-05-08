using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{

    // Klasse gemaakt door: Frans Orsel
    // Source: https://simpledevcode.wordpress.com/2015/07/07/hash-tables-tutorial-c-c-java/

    public class QuadraticHash<T> where T : IComparable
    {
        private const int SIZE = 101;

        ArrayList[] data;
        // De funtie om deze collectie aan te roepen. Deze functie heeft geen verdere invoer nodig, omdat hij gebruik maakt
        // van een vaste SIZE. Er wordt dan vervolgens een array mee aangemaakt.
        public QuadraticHash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= SIZE - 1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        // Deze methode is de methode waarom het een hash is. Hiermee wordt namelijk een hashgetal gemaakt.
        public int Hash(string s, int count)
        {
            long tot = 0;

            char[] charray;
            charray = s.ToCharArray();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                tot += 1 * tot + (int)charray[i];
            }
            tot = tot % data.GetUpperBound(0);
            if (tot < 0)
            {
                tot += data.GetUpperBound(0);
            }
            tot = tot % SIZE;

            // Deze methode is de methode waardoor dit een Quadratichash betreft. Wanneer namelijk het hashgetal (en dus de plaats) 
            // al bestaat, voert hij een berekening uit om de hash te veranderen naar een (hopelijk) lege plaats.
            if (count > 0)
            {
                tot = (tot + count*1 + 1*count*count) % SIZE;
            }
            return (int)tot;
        }

        // Deze methode voegt een generic item toe en vraagt daar ook een value op. Deze value is nodig om te hashen.
        public void AddItem(T item, string value)
        {
            HashNode<T> Node = new HashNode<T>(item, value);
            Insert(Node);
        }

        // Deze methode voegt een nieuwe gehashte node toe aan de gecreëerde array. Ook wordt hier gecheckt of de plaats reeds
        // bezet is. Is dit het geval, wordt er opnieuw gehasht met een verhoogde count.
        public void Insert(HashNode<T> item)
        {
            int hash_value;
            hash_value = Hash(item.value, item.count);
            while (data[hash_value].Contains(item.value))
            {
                item.count++;
                hash_value = Hash(item.value, item.count);
            }
            data[hash_value].Add(item);
        }
    }
}
