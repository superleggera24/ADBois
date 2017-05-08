using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt door: Frans Orsel
    // Source: Datastructures & Algorithms in C# door Michael McMillan

    // Klasse voor het creëeren van een eigen Stack
    public class RandStack<T>
    {
        private int p_index;
        private List<T> list;
        
        public RandStack()
        {
            list = new List<T>();
            p_index = -1;
        }

        public int count
        {
            get { return list.Count; }
        }

        public void push(T item)
        {
            list.Add(item);
            p_index++;
        }

        public T pop()
        {
            T obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }

        public void clear()
        {
            list.Clear();
            p_index = -1;
        }

        public T peek()
        {
            return list[p_index];
        }
    }
}
