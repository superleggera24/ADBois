using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Hash
{
    public class BucketHash<T> where T : IComparable
    {
//        private const int SIZE = 50;
//        //maak array generic aan
//        //public static T[] Bucket(T[] array)
//        {
//            for (int i = 0; i <= SIZE - 1; i++)
//                //array[i] = new ArrayList();
//            return array;
//        }
        
//    }
//}

//public class BucketHash
//{
//    private const int SIZE = 101;
    
//    public BucketHash()
//    {
//        data = new ArrayList[SIZE];
//        for (int i = 0; i <= SIZE - 1; i++)
//            data[i] = new ArrayList(4);
//    }
//    public int Hash(string s)
//    {
//        long tot = 0;
//        char[] charray;
//        charray = s.ToCharArray();
//        for (int i = 0; i <= s.Length - 1; i++)
//            tot += 37 ∗ tot + (int)charray[i];
//        tot = tot % data.GetUpperBound(0);
//        if (tot < 0)
//            tot += data.GetUpperBound(0);
//        return (int)tot;
//    }
//    public void Insert(string item)
//    {
//        int hash_value;
//        hash_value = Hash(value);
//        if (data[hash_value].Contains(item))
//            data[hash_value].Add(item);
//    }
//    public void Remove(string item)
//    {
//        int hash_value;
//        hash_value = Hash(item);
//        if (data[hash_value].Contains(item))
//            data[hash_value].Remove(item);
//    }
}