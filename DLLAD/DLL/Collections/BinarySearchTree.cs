using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class BinaryNode<T> //maak node aan
    {
        public T Data; //data in the node
        public BinaryNode<T> Left; //adress node left
        public BinaryNode<T> Right; //adress node right
        
        public string DisplayNode() //return data as string
        {
            string display = Data.ToString();
            return display;
        }
    }
    public class BinarySearchTree<T> where T : IComparable //maak binary search tree aan
    {
        public static BinaryNode<T> root; //de rootnode, bovenste node in de tree

        public BinarySearchTree()
        {
            root = null; //zorg dat de root null is bij start van de tree
        }
            
        public void Insert(T value) //insert data in de tree
        {
            var comparer = Comparer<T>.Default;
            BinaryNode<T> newNode = new BinaryNode<T>();
            newNode.Data = value;

            if (root == null) //als de root niet bestaat
            {
                root = newNode; //set de rootnode
            }
            else
            {
                BinaryNode<T> current = root; //als root bestaat set de current node gelijk aan root
                BinaryNode<T> parent;

                while (true)
                {
                    parent = current; //set de parentnode gelijk aan current
                    if (comparer.Compare(value, current.Data) < 0) //check value van nieuwe data met de current data
                    {
                        current = current.Left;
                        
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else //als de value niet kleiner is dan set als right node
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

        public static T FindMin() // Vind kleinste value
        {
            BinaryNode<T> current = root; //begin bij root
            while (!(current.Left == null)) //zolang linker node niet null is
            {
                current = current.Left; // set de current als current.Left
            }
            return current.Data; //wanneer linkernode null is is de laatstgevonden node de kleinste waarde
        }

        public static T FindMax() //vind de grootste value
        {
            BinaryNode<T> current = root; //begin bij de root
            while (!(current.Right == null)) //zolang de rechternode niet null is
            {
                current = current.Right; //set de current als current.right
            }
            return current.Data; //zodra rechternode null is is de laatstgevonden current de grootste waarde
        }

        public static BinaryNode<T> Find(int key) //zoekfunctie op key
        {
            BinaryNode<T> current = root; //begin bij de root
            while (!(current.Data.Equals(key))) //zodra de key gelijk is aan de data
            {
                if (current.Data.CompareTo(key) > 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    current = null;
                }
            }
            return current; //weergeef de current node
        }
    }
}
