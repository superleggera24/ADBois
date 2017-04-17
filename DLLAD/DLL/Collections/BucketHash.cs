using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Het genereren van een aparte klasse zodat er een string wordt geleverd voor het creëren van de buckethash
    public class HashNode<T>
    {
        public T item { get; set; }
        public string value { get; set; }
        public int count { get; set; }

        public HashNode(T Item, string Value)
        {
            item = Item;
            value = Value;
            count = 0;
        }
    }

    public class BucketHash<T> where T : IComparable
    {
        private const int SIZE = 101;

        ArrayList[] data;

        public BucketHash()
        {
            data = new ArrayList[SIZE];
            for(int i = 0; i <= SIZE-1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        public int Hash(string s)
        {
            long tot = 0;

            char[] charray;
            charray = s.ToCharArray();
            for(int i=0; i <= s.Length-1; i++)
            {
                tot += 37 * tot + (int)charray[i];
            }
            tot = tot % data.GetUpperBound(0);
            if (tot < 0)
            {
                tot += data.GetUpperBound(0);
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
            hash_value = Hash(item.value);
            if (data[hash_value].Contains(item.value))
            {
                data[hash_value].Add(item);
            }
        }

        public void Remove(string value)
        {
            int hash_value;
            hash_value = Hash(value);
            if (data[hash_value].Contains(value))
            {
                data[hash_value].Remove(value);
            }
        }
    }
}
