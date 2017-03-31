using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandQueue<T>
    {
        public static Queue<T> ListQueue = new Queue<T>();

        public void Enqueue(T item)
        {
            ListQueue.Enqueue(item);
        }

        public virtual void Dequeue()
        {
            ListQueue.Dequeue();
        }

        public Queue<T> GetListQueue()
        {
            return ListQueue;
        }

        public static void CreateQueue(List<T> List)
        {
            foreach (T item in List)
            {
                ListQueue.Enqueue(item);
            }
        }
    }
}
