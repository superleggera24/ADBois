using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt door: Frans Orsel
    // Source: Datastructures & Algorithms in C# door Michael McMillan

    public class Iterator<T> where T : IComparable
    {
        // De iterator class maakt ook gebruik van de Node class. Deze class heeft een vorige node, een header node en een huidige node
        // nodig, en initieert deze dus.
        private Node<T> current { get; set; }
        private Node<T> header { get; set; }
        private Node<T> prev { get; set; }
        RandLinkedList<T> theList;

        // Hier wordt de iterator begonnen, en heeft daarvoor de eerste node uit de ingevoerde lijst nodig en maakt deze de huidige node. 
        // Ook wordt de 'vorige' node geset, naar null.
        public Iterator(RandLinkedList<T> list)
        {
            this.theList = list;
            current = theList.getFirst();
            prev = null;
        }

        // Deze methode selecteert de volgende node en wordt gebruikt in andere methoden.
        public void NextLink()
        {
            prev = current;
            current = current.next;
        }

        // Deze methode is een simpele getmethode om de huidige node weer te geven.
        public Node<T> GetCurrent()
        {
            return current;
        }

        // Deze methode gebruik je als je een element vóór de volgende node wilt implementeren.
        public void InsertBefore(T theElement)
        {
            Node<T> newNode = new Node<T>(theElement);
            
            // Er zit echter ook een errorafhandeling in, die zorgt dat de methode niets doet wanneer de huidige node de header is.
            if (current != header)
            {
                newNode.next = prev.next;
                prev.next = newNode;
                current = newNode;
            }
        }

        // Deze methode gebruik je als je een element na de volgende node wilt implementeren.
        public void InsertAfter(T theElement)
        {
            Node<T> newnode = new Node<T>(theElement);
            newnode.next = current.next;
            current.next = newnode;
            NextLink();
        }
    }
}
