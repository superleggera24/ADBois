using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Node<T> where T : IComparable
    {
        public T Element;
        public Node<T> Link;
        
        public Node()
        {
            Element = default(T);
            Link = null;
        }
        public Node(T theElement)
        {
            Element = theElement;
            Link = null;
        }
    }
}
