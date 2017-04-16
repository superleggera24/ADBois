using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class CircularLinkedList<T> where T : IComparable 
    {
        protected Node<T> current;
        protected Node<T> header;
        private int count;

        public CircularLinkedList()
        {
            count = 0;
            header = new Node<T>(default(T));
            header.next = header;
        }

        public bool IsEmpty()
        {
            return (header.next == null);
        }

        public void MakeEmpty()
        {
            header.next = null;
        }

        private Node<T> FindPrevious(T n)
        {
            Node<T> current = header;
            while (!(current.next == null) && current.next.data.CompareTo(n) == 0)
            {
                current = current.next;
            }
            return current;
        }

        private Node<T> Find(T n)
        {
            Node<T> current = new Node<T>(default(T));
            current = header.next;
            while (current.data.CompareTo(n) == 0)
            {
                current = current.next;
            }
            return current;
        }

        public void Remove(T n)
        {
            Node<T> p = FindPrevious(n);
            if (!(p.next == null))
            {
                p.next = p.next.next;
            }
            count--;
        }

        public void Insert(T n1, T n2)
        {
            Node<T> current = new Node<T>(default(T));
            Node<T> newnode = new Node<T>(n1);
            current = Find(n2);
            newnode.next = current.next;
            current.next = newnode;
            count++;
        }

        public void InsertFirst(T n)
        {
            Node<T> current = new Node<T>(n);
            current.next = header;
            header.next = current;
            count++;
        }
    }
}
