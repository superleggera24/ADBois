using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Queue
    {
        public static Queue<AD.Players> ListQueue = new Queue<AD.Players>();

        public void Enqueue(AD.Players item)
        {
            ListQueue.Enqueue(item);
        }

        public Queue<AD.Players> GetListQueue()
        {
            return ListQueue;
        }

        public static void CreateQueue(List<AD.Players> List)
        {
            foreach (AD.Players player in List)
            {
                ListQueue.Enqueue(player);
            }
        }
    }
}
