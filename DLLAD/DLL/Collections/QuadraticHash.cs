using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class QuadraticHash<T> where T : IComparable
    {
        private const int SIZE = 101;

        ArrayList[] data;

        public QuadraticHash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= SIZE - 1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

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

            if (count > 0)
            {
                tot = (tot + count*1 + 1*count*count) % SIZE;
            }
            return (int)tot;
        }

        public void AddItem(T item, string value)
        {
            HashNode<T> Node = new HashNode<T>(item, value);
            Insert(Node);
        }

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
