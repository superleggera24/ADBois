using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Queue<T> where T : IEnumerable<int>
    {
        public static Queue<T> RandomQueue = new Queue<T>();

        public void Enqueue(T item)
        {
            RandomQueue.Enqueue(item);
        }

    }
}
