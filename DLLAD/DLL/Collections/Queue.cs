using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Queue<T> where T : IEnumerable<T>
    {
        public static Queue<T> ListQueue = new Queue<T>();

        public void Enqueue(T item)
        {
            ListQueue.Enqueue(item);
        }

    }
}
