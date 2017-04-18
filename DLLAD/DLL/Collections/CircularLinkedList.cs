using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class CircularLinkedList<T> where T : IComparable 
    {
        protected Node<T> current; //de current node
        protected Node<T> header; //de eerste node
        private int count; //positie in de lijst bijhouden

        public CircularLinkedList()
        {
            count = 0;
            header = new Node<T>(default(T));
            header.next = header;
        }

        //vind volgende node, tot deze null is.
        private Node<T> FindPrevious(T n)
        {
            Node<T> current = header;
            while (!(current.next == null) && current.next.data.CompareTo(n) == 0) //wanneer volgende node gevuld is ga naar next
            {
                current = current.next; //switch naar volgende node
            }
            return current;
        }

        //vind een node
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

        //verwijder een node
        public void Remove(T n)
        {
            Node<T> p = FindPrevious(n);
            if (!(p.next == null))
            {
                p.next = p.next.next;
            }
            count--;
        }

         //insert nodes
         public void InsertFirst(T n)
        {
            Node<T> current = new Node<T>(n);
            current.next = header;
            header.next = current;
            count++;
        }
    }
}
