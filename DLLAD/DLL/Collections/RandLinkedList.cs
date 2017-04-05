using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandLinkedList<T> where T : IComparable
    {
        protected Node<T> header;

        public RandLinkedList()
        {
            header = new Node<T>();
        }

        private Node<T> Find(Node<T> item)
        {
            Node<T> current = new Node<T>();
            current = header;
            while(header != item) // header != item)
            {
                current = current.Link;
            }
            return current;
        }

        public void Insert(T newItem, Node<T> after)
        {
            Node<T> current = new Node<T>();
            Node<T> newNode = new Node<T>(newItem);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }

        private Node<T> FindPrevious(Node<T> item)
        {
            Node<T> current = header;
            while(!(current.Link == null) && (current.Link != item))
            {
                current = current.Link;
            }
            return current;
        }

        public void Remove(Node<T> n)
        {
            Node<T> p = FindPrevious(n);
            if (!(p.Link == null))
            {
                p.Link = p.Link.Link;
            }
        }

        public void PrintList()
        {
            Node<T> current = new Node<T>();
            current = header;
            while (!(current.Link == null))
            {
                // Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }
    }
}
