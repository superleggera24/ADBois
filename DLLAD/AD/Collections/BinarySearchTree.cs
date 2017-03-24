using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{

    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }

    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
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
        }

        // Vind laagste/minimum waarde door linker nodes te volgen.
        public int FindMin()
        {
            Node current = root;
            while (!(current.Left == null))
                current = current.Left;
            return current.Data;
        }

        // Vind hoogste/maximum waarde door rechter nodes te volgen.
        public int FindMax()
        {
            Node current = root;
            while (!(current.Right == null))
                current = current.Right;
            return current.Data;
        }

        // Vind de aangegeven key value
        public Node Find(int key)
        {
            Node current = root;
            while (current.iData != key)
            {
                if (key < current.iData)
                    current = current.Left;
                else
                current = current.Right;
                if (current == null)
                    return null;
            }
            return current;
        }


    }
}
