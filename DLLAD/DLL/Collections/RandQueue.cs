using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandQueue<T> where T : IEnumerable<T>
    {

        public static Queue<T> _RandomQueue = new Queue<T>();
        
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

        public static Queue<T> RandomQueue
        {
            get { return RandomQueue; }
        }

        public static void InitiateRandQueue(List<T> Numbers)
        {
            
            Random RandomNo = new Random();
            for(int index = 0; index < 1000; index++)
            {
                
                
            }
        }
        
    }
}
