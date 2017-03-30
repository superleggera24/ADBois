using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandStack
    {
        public static Stack<AD.Players> _RandomStack;

        public static Stack<AD.Players> RandomStack
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

        public static void InitiateRandStack(List<AD.Players> List)
        {
            _RandomStack = new Stack<AD.Players>();
            Random RandomNo = new Random();
            foreach (AD.Players player in List)
            {
                
                _RandomStack.Push(player);
                
            }
        }
        
        public static AD.Players PeekStack()
        {
            return _RandomStack.Peek();
        }
    }
}
