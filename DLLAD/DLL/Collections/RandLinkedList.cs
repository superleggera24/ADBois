using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandLinkedList<T> where T : IComparable
    {
        private Node<T> head;        

        public void printAllNodes()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(T data)
        {
            Node<T> toAdd = new Node<T>();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                head = new Node<T>();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node<T> toAdd = new Node<T>();
                toAdd.data = data;

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }
}
