using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt door: Frans Orsel
    // Source: Datastructures & Algorithms in C# door Michael McMillan

    public class RandLinkedList<T> where T : IComparable
    {
        private Node<T> head; // Deze lijst heeft maar een node nodig om geinitieerd te worden. De eerste node.

        public void AddFirst(T data) // Deze methode voegt een node toe aan het begin van de lijst.
        {
            Node<T> toAdd = new Node<T>(data);

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(T data) // Deze methode voegt een node toe aan het einde van de lijst.
        {
            if (head == null) // Als er nog geen inhoud in de eerste node zit, vult hij deze eerst in.
            {
                head = new Node<T>(data);

                head.data = data;
                head.next = null;
            }
            else
            {
                Node<T> toAdd = new Node<T>(data);
                toAdd.data = data;

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public Node<T> getFirst()
        {
            return head;
        }
    }
}
