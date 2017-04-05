using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandQueue<T>
    {
        private List<T> Queue;

        public RandQueue()
        {
            Queue = new List<T>();
        }

        public void Enqueue(T item)
        {
            Queue.Add(item);
        }

        public virtual void Dequeue()
        {
            Queue.RemoveAt(0);
        }

        public object Peek()
        {
            return Queue[0];
        }

        public void ClearQueue()
        {
            Queue.Clear();
        }

        public int Count()
        {
            return Queue.Count;
        }
    }
}
