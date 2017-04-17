using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Iterator<T> where T : IComparable
    {
        private Node<T> current;
        private Node<T> header;
        private Node<T> prev;
        RandLinkedList<T> theList;
        public Iterator(RandLinkedList<T> list)
        {
            theList = list;
            current = theList.getFirst();
            prev = null;
        }

        public void NextLink()
        {
            prev = current;
            current = current.next;
        }

        public Node<T> GetCurrent()
        {
            return current;
        }

        public void InsertBefore(T theElement)
        {
            Node<T> newNode = new Node<T>(theElement);
            if (current == header)
            {
                //throw new InsertBeforeHeaderException();
            }
            else
            {
                newNode.next = prev.next;
                prev.next = newNode;
                current = newNode;
            }
        }

        public void InsertAfter(T theElement)
        {
            Node<T> newnode = new Node<T>(theElement);
            newnode.next = current.next;
            current.next = newnode;
            NextLink();
        }
    }
}
