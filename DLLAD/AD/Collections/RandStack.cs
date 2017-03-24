using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandStack<T> 
    {
        public static Stack<int> _RandomStack;

        public static Stack<int> RandomStack
        {
            get { return _RandomStack; }
        }

        private static int highest;
        public static int Highest
        {
            get { return highest; }
            set { highest = value; }
        }
        private static int lowest;
        public static int Lowest
        {
            get { return lowest; }
            set { lowest = value; }
        }

        public static void InitiateRandStack(int[] Numbers)
        {
            _RandomStack = new Stack<int>();
            Random RandomNo = new Random();
            for (int index = 0; index < 1000; index++)
            {
                int No = Numbers[index];
                _RandomStack.Push(No);
                if (index == 0)
                {
                    Highest = 0;
                    Lowest = 1000;
                }
                if (No > Highest)
                {
                    Highest = No;
                }
                else if (Lowest > No)
                {
                    Lowest = No;
                }
            }
        }
        
        public static int PeekStack()
        {
            return _RandomStack.Peek();
        }
    }
}
