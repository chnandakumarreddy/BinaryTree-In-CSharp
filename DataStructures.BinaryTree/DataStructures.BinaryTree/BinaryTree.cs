using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class BinaryTree<T>
    {
        public class Node
        {
            public T data { get; set; }
            public Node right { get; set; }
            public Node left { get; set; }

            public Node(T nodeData)
            {
                data = nodeData;
                right = null;
                left = null;
            }
        }

        public BinaryTree()
        {
            headNode = null;
            Count = 0;
        }

        public int Count { get; private set; }
        private Node headNode { get; set; }

        public Node Insert(T data)
        {
            Node newNode = new Node(data);
            if (headNode == null)
            {
                headNode = newNode;
                newNode.left = newNode.right = null;
                Count++;
                return headNode;
            }
            else
            {
                return InsertNewNode(headNode, data);
            }
            
        }

        private Node InsertNewNode(Node rootNode, T data)
        {
            if (rootNode == null)
            {
                rootNode = new Node(data);
                rootNode.left = rootNode.right = null;
                Count++;
            }
            else
            {
                if (Comparer<T>.Default.Compare(data, rootNode.data) < 0)
                {
                    rootNode.left = InsertNewNode(rootNode.left, data);
                }
                else
                {
                    rootNode.right = InsertNewNode(rootNode.right, data);
                }
            }
            return rootNode;
        }

        public Node SearchBinaryTree(T data)
        {
            return SearchBinaryTreeRecursively(headNode, data);
        }

        private Node SearchBinaryTreeRecursively(Node parentNode, T data)
        {
            if (parentNode == null)
            {
                return null;
            }
            if (parentNode.data.Equals(data))
            {
                return parentNode;
            }
            else
            {
                if (Comparer<T>.Default.Compare(data, parentNode.data) < 0)
                {
                    return SearchBinaryTreeRecursively(parentNode.left, data);
                }
                else
                {
                    return SearchBinaryTreeRecursively(parentNode.right, data);
                }
            }
        }

        public int GetTreeDepth()
        {
            return getTreeDepth(headNode);
        }

        private int getTreeDepth(Node rootNode)
        {
            if (rootNode == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(getTreeDepth(rootNode.left), getTreeDepth(rootNode.right));
            }
        }
    }
}
