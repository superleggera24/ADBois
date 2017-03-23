using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandLinkedList<T> where T : IComparable
    {
        public static LinkedList<int> _RandomLinkedList;

        public static LinkedList<int> RandomLinkedList
        {
            get { return _RandomLinkedList; }
        }

        public static void InitiateLinkedList()
        {
            //RandArray<>.InitiateArray
            //RandomLinkedList<int> RandLinkedList = new LinkedList<int>;
        }
    }
}
