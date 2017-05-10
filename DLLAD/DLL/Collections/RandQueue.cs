using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt door: Frans Orsel en Dennis Dekker
    // Source: Datastructures & Algorithms in C# door Michael McMillan

    public class RandQueue<T>
    {
        private List<T> Queue;

        // Met deze methode kan een queue van onze eigen klasse (deze) worden geinitieerd.
        public RandQueue()
        {
            Queue = new List<T>();
        }

        // Deze methode voegt een item toe aan de list die fungeert als queue.
        public void Enqueue(T item)
        {
            Queue.Add(item);
        }

        // Hiermee verwijder je het item dat het eerste is toegevoegt.
        public virtual void Dequeue()
        {
            Queue.RemoveAt(0);
        }
    }
}
