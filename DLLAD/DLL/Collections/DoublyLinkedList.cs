using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class DoublyLinkedList<T> where T : IComparable
    {
        private Node<T> head; //de eerste node 
        private Node<T> tail; //de laatste node

        public DoublyLinkedList()
        {
        }

        private Node<T> GetAt(int index) //??
        {
            var current = head; //1e node is head
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

        public void Add(T data) //vul de doubly linked list collectie
        {
            if (head == null)//wanneer er geen head bestaat
            {
                head = new Node<T>(data); //new node is head
                tail = head; //tail is ook head
            }
            else //zodra de head bestaat
            {
                tail.next = new Node<T>(data); //nieuwe node opslaan als tail.next
                tail.next.prev = tail;
                tail = tail.next; //set de laatste node als tail
            }
        }
    }
}
