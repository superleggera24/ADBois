using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse van de priorityqueue.
    public class RandPriorityQueue<Tpriority, TItem>
    {
        // Hier wordt een priorityqueue geinitieerd.
        readonly SortedDictionary<Tpriority, Queue<TItem>> _subqueues;

        // Deze methode staat de creatie van de klasse toe.
        public RandPriorityQueue(IComparer<Tpriority> priorityComparer)
        {
            _subqueues = new SortedDictionary<Tpriority, Queue<TItem>>(priorityComparer);
        }

        public RandPriorityQueue() : this(Comparer<Tpriority>.Default) { }

        // Deze methode zorgt ervoor dat er een item kan worden toegevoegd, en geeft er een prioriteit aan.
        public void Enqueue(Tpriority priority, TItem item)
        {
            if (!_subqueues.ContainsKey(priority))
            {
                AddQueueOfPriority(priority);
            }

            _subqueues[priority].Enqueue(item);
        }

        // Deze methode voegt een item toe aan een nieuwe queue, die gecreëerd wordt omdat die prioriteit nog niet bestaat.
        // Deze methode wordt aangeroepen vanuit de Enqueue methode.
        private void AddQueueOfPriority(Tpriority priority)
        {
            _subqueues.Add(priority, new Queue<TItem>());
        }
    }
}
