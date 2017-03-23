using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class RandQueue<T> where T : IComparable
    {
        public static Queue<int> _RandomQueue;
        private static int highest;
        public static int Highest
        {
            get
            {
                return highest;
            }
            set
            {
                highest = value;
            }
        }
        private static int lowest;
        public static int Lowest
        {
            get
            {
                return lowest;
            }
            set
            {
                lowest = value;
            }
        }

        public static Queue<int> RandomQueue
        {
            get { return _RandomQueue; }
        }

        public static void InitiateRandQueue(int[] Numbers)
        {
            _RandomQueue = new Queue<int>();
            Random RandomNo = new Random();
            for(int index = 0; index < 1000; index++)
            {
                int No = Numbers[index];
                _RandomQueue.Enqueue(No);
                if (index == 0)
                {
                    Highest = 0;
                    Lowest = 1000;
                }
                if(No > Highest)
                {
                    Highest = No;
                }
                else if (Lowest > No)
                {
                    Lowest = No;
                }
            }
        }
        public static int PeekRandom()
        {
            return _RandomQueue.Peek();
        }
    }
}
