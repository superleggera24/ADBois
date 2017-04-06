using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class BinaryNode<T>
    {
        public T Data;
        public BinaryNode<T> Left;
        public BinaryNode<T> Right;
        
        public string DisplayNode()
        {
            string display = Data.ToString();
            return display;
        }
    }
    public class BinarySearchTree<T>
    {
        public static BinaryNode<T> root;

        public BinarySearchTree()
        {
            root = null;
        }
            
        public void Insert(T value)
        {
            var comparer = Comparer<T>.Default;
            BinaryNode<T> newNode = new BinaryNode<T>();
            newNode.Data = value;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryNode<T> current = root;
                BinaryNode<T> parent;

                while (true)
                {
                    parent = current;
                    if (comparer.Compare(value, current.Data) < 0)
                    {
                        current = current.Left;
                        
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public static T FindMin()
        {
            BinaryNode<T> current = root;
            while (!(current.Left == null))
            {
                current = current.Left;
            }
            return current.Data;
        }

        public static T FindMax()
        {
            BinaryNode<T> current = root;
            while (!(current.Right == null))
            {
                current = current.Right;
            }
            return current.Data;
        }

        public static BinaryNode<T> Find(T key)
        {
            var comparer = Comparer<T>.Default;
            BinaryNode<T> current = root;
            while (current.Data.Equals(key))
            {
                if (comparer.Compare(key, current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }
    }
}
