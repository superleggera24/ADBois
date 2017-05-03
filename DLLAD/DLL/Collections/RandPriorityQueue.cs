using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandPriorityQueue<Tpriority, TItem>
    {
        readonly SortedDictionary<Tpriority, Queue<TItem>> _subqueues;

        public RandPriorityQueue(IComparer<Tpriority> priorityComparer)
        {
            _subqueues = new SortedDictionary<Tpriority, Queue<TItem>>(priorityComparer);
        }

        public RandPriorityQueue() : this(Comparer<Tpriority>.Default) { }

        public bool HasItems
        {
            get { return _subqueues.Any(); }
        }

        public int Count
        {
            get { return _subqueues.Sum(q => q.Value.Count); }
        }

        public void Enqueue(Tpriority priority, TItem item)
        {
            if (!_subqueues.ContainsKey(priority))
            {
                AddQueueOfPriority(priority);
            }

            _subqueues[priority].Enqueue(item);
        }

        private void AddQueueOfPriority(Tpriority priority)
        {
            _subqueues.Add(priority, new Queue<TItem>());
        }

        public TItem Dequeue()
        {
            if (_subqueues.Any())
            { return DequeueFromHighPriorityQueue(); }
            else
            {
                throw new InvalidOperationException("De queue is leeg");
            }
        }

        private TItem DequeueFromHighPriorityQueue()
        {
            KeyValuePair<Tpriority, Queue<TItem>> first = _subqueues.First();
            TItem nextItem = first.Value.Dequeue();
            if (!first.Value.Any())
            {
                _subqueues.Remove(first.Key);
            }
            return nextItem;
        }

        public TItem Peek()
        {
            if (HasItems)
            {
                return _subqueues.First().Value.Peek();
            }
            else
            {
                throw new InvalidOperationException("Queue is leeg!");
            }
        }
    }
}
