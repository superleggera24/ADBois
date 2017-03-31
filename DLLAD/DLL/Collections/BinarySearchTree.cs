using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class BinarySearchTree<Tkey, Tvalue> where Tkey : IComparable<Tkey>
    {

        //public BinaryNode<T> parent { get; set; }
        //public BinaryNode<T> left { get; set; }
        //public BinaryNode<T> right { get; set; }


        //protected class, alleen zichtbaar voor classes binnen top level class BinarySearchTree
        protected class BinaryKeyValueNode<Tkey, Tvalue> where Tkey : IComparable<Tkey> //maak de nodes comparable met elk andere type dat IComparable implementeerd
        {
            public Tkey Key { get; set; } // key value van de node
            public Tvalue Value { get; set; } // value bijbehorende de node
            public BinaryKeyValueNode<Tkey, Tvalue> Parent { get; set; } //parent node
            public BinaryKeyValueNode<Tkey, Tvalue> LeftChild { get; set; } //left node (kleinste value)
            public BinaryKeyValueNode<Tkey, Tvalue> RightChild { get; set; } //right node (grootste value)
            public BinaryKeyValueNode(Tkey key, Tvalue value)
            {
                Value = value;
                Key = key;
            }
        }

        //elke node heeft een key en een value en behoud een referentie naar beide (subtrees) childnodes en de betreffende parent
        private Random random;
        protected BinaryKeyValueNode<Tkey, Tvalue> Root { get; set; }
        public int Count { get; protected set; }

        public BinarySearchTree()
        {
            Root = null; // reference naar de root node, begin null
            random = new Random(1);
            Count = 0;
        }


        //vul de tree
        public void Insert(Tkey key, Tvalue value)
        {
            BinaryKeyValueNode<Tkey, Tvalue> parent = null;
            BinaryKeyValueNode<Tkey, Tvalue> current = Root;
            int compare = 0;

            while (current != null) //zodra root bestaat
            {
                parent = current;
                compare = current.Key.CompareTo(key);
                current = compare < 0 ? current.RightChild : current.LeftChild;
            }
            BinaryKeyValueNode<Tkey, Tvalue> newNode = new BinaryKeyValueNode<Tkey, Tvalue>(key, value);
            if (parent != null)
                if (compare < 0) //als de waarde precede (-1) dan wordt deze rightchild
                    parent.RightChild = newNode;
                else // bij compareto result 0 of 1 dan wordt deze leftchild
                    parent.LeftChild = newNode;
            else
                Root = newNode;
            newNode.Parent = parent;
            Count++;
        }

        public Tvalue FindFirst(Tkey key)
        {
            return FindNode(key).Value;
        }

        public Tvalue FindFirstOrDefault(Tkey key)
        {
            var node = FindNode(key, false);
            return node == null ? default(Tvalue) : node.Value;
        }

        protected BinaryKeyValueNode<Tkey, Tvalue> FindNode(Tkey key, bool ExceptionIfKeyNotFound = true)
        {
            BinaryKeyValueNode<Tkey, Tvalue> current = Root;
            while (current != null)
            {
                int compare = current.Key.CompareTo(key);
                if (compare == 0)
                    return current;
                if (compare < 0)
                    current = current.RightChild;
                else
                    current = current.LeftChild;
            }
            if (ExceptionIfKeyNotFound)
                throw new KeyNotFoundException();
            else
                return null;
        }

        protected void DeleteNode(BinaryKeyValueNode<Tkey, Tvalue> node)
        {
            if (node == null)
                throw new ArgumentNullException();
            if (node.LeftChild != null && node.RightChild != null) //2 childs  
            {
                BinaryKeyValueNode<Tkey, Tvalue> replaceBy = random.NextDouble() > .5 ? InOrderSuccesor(node) : InOrderPredecessor(node);
                DeleteNode(replaceBy);
                node.Value = replaceBy.Value;
                node.Key = replaceBy.Key;
            }
            else //1 or less childs  
            {
                var child = node.LeftChild == null ? node.RightChild : node.LeftChild;
                if (node.Parent.RightChild == node)
                    node.Parent.RightChild = child;
                else
                    node.Parent.LeftChild = child;
            }
            Count--;
        }

        protected BinaryKeyValueNode<Tkey, Tvalue> InOrderSuccesor(BinaryKeyValueNode<Tkey, Tvalue> node)
        {
            BinaryKeyValueNode<Tkey, Tvalue> succesor = node.RightChild;
            while (succesor.LeftChild != null)
                succesor = succesor.LeftChild;
            return succesor;
        }

        protected BinaryKeyValueNode<Tkey, Tvalue> InOrderPredecessor(BinaryKeyValueNode<Tkey, Tvalue> node)
        {
            BinaryKeyValueNode<Tkey, Tvalue> succesor = node.LeftChild;
            while (succesor.RightChild != null)
                succesor = succesor.RightChild;
            return succesor;

        }

        public IEnumerable<Tvalue> TraverseTree(DepthFirstTraversalMethod method)
        {
            return TraverseNode(Root, method);
        }

        protected IEnumerable<Tvalue> TraverseNode(BinaryKeyValueNode<Tkey, Tvalue> node, DepthFirstTraversalMethod method)
        {
            IEnumerable<Tvalue> TraverseLeft = node.LeftChild == null ? new Tvalue[0] : TraverseNode(node.LeftChild, method),
                TraverseRight = node.RightChild == null ? new Tvalue[0] : TraverseNode(node.RightChild, method),
                Self = new Tvalue[1] { node.Value };
            switch (method)
            {
                case DepthFirstTraversalMethod.PreOrder:
                    return Self.Concat(TraverseLeft).Concat(TraverseRight);
                case DepthFirstTraversalMethod.InOrder:
                    return TraverseLeft.Concat(Self).Concat(TraverseRight);
                case DepthFirstTraversalMethod.PostOrder:
                    return TraverseLeft.Concat(TraverseRight).Concat(Self);
                default:
                    throw new ArgumentException();
            }
        }

        public enum DepthFirstTraversalMethod
        {
            PreOrder,
            InOrder,
            PostOrder
        }

    }
}
