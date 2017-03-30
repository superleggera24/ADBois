using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandLinkedList<T> where T : IComparable
    {
        public static LinkedList<T> _RandomLinkedList = new LinkedList<T>();

        public static LinkedList<T> RandomLinkedList
        {
            get { return _RandomLinkedList; }
        }

        public static void InitiateLinkedList(List<T> List)
        {
            foreach (T player in List)
            {

            }
        }
    }
}
