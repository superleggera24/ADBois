using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Node<T>// where T : IComparable
    {
        public Node<T> next; //opvolgende node
        public Node<T> prev; //previous node
        public T data { get; set; } //get en set de data
        
        public Node(T Data) //zet data weg in een Node
            {
            data = Data;
            }
    }
}
