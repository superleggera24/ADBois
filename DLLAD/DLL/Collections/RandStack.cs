using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class RandStack<T>
    {
        public static Stack<T> _RandomStack;

        public static Stack<T> RandomStack
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

        public static void InitiateRandStack(List<T> List)
        {
            _RandomStack = new Stack<T>();
            Random RandomNo = new Random();
            foreach (T player in List)
            {

                _RandomStack.Push(player);

            }
        }
        public void Push(T item)
        {
            _RandomStack.Push(item);
        }

        public static T PeekStack()
        {
            return _RandomStack.Peek();
        }
    }
}
