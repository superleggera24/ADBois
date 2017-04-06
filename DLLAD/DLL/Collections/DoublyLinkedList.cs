using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class DoublyLinkedList<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;
        public DoublyLinkedList()
        {
        }

        private Node<T> GetAt(int index)
        {
            var current = head;
            for(int i=0;i<index;i++)
            {
                if (current == null)
                {
                    return null;
                }
                current = current.next;
            }
            return current;
        }

        public void Add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else
            {
                tail.next = new Node<T>(data);
                tail.next.prev = tail;
                tail = tail.next;
            }
        }
    }
}
