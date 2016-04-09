using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class BinaryTree
    {
        public class Node
        {
            public int data { get; set; }
            public Node right { get; set; }
            public Node left { get; set; }

            public Node(int nodeData)
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

        public Node Insert(int data)
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

        private Node InsertNewNode(Node rootNode, int data)
        {
            if (rootNode == null)
            {
                rootNode = new Node(data);
                rootNode.left = rootNode.right = null;
                Count++;
            }
            else
            {
                if (data < rootNode.data )
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

        public Node SearchBinaryTree(int data)
        {
            return SearchBinaryTreeRecursively(headNode, data);
        }

        private Node SearchBinaryTreeRecursively(Node parentNode, int data)
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
                if (data < parentNode.data)
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

        /// <summary>
        /// Traverse the entire tree in InOrder routine
        /// </summary>
        /// <returns></returns>
        public List<int> GetInOrderTraversal()
        {
            return InOrderTraversal(headNode);
        }

        private List<int> InOrderTraversal(Node node)
        {
            List<int> traversedData = new List<int>();
            if (node != null)
            {
                traversedData.AddRange(InOrderTraversal(node.left));
                traversedData.Add(node.data);
                traversedData.AddRange(InOrderTraversal(node.right));
            }
            return traversedData;
        }

        public List<int> GetPreOrderTraversal()
        {
            return PreOrderTraversal(headNode);
        }

        private List<int> PreOrderTraversal(Node node)
        {
            List<int> traversedData = new List<int>();
            if (node != null)
            {
                traversedData.Add(node.data);
                traversedData.AddRange(PreOrderTraversal(node.left));
                traversedData.AddRange(PreOrderTraversal(node.right));
            }
            return traversedData;
        }

        public List<int> GetPostOrderTraversal()
        {
            return PostOrderTraversal(headNode);
        }

        private List<int> PostOrderTraversal(Node node)
        {
            List<int> traversedNode = new List<int>();
            if (node != null)
            {
                traversedNode.AddRange(PostOrderTraversal(node.left));
                traversedNode.AddRange(PostOrderTraversal(node.right));
                traversedNode.Add(node.data);
            }

            return traversedNode;
        }

        public bool HasPathSum(int sum)
        {
            return HasPathSumInTree(headNode, sum);
        }

        private bool HasPathSumInTree(Node rootNode, int sum)
        {
            if (rootNode == null)
            {
                return (sum == 0);
            }
            else
            {
                return HasPathSumInTree(rootNode.left, sum - rootNode.data)
                    || HasPathSumInTree(rootNode.right, sum - rootNode.data);
            }
        }

        public void DoMirror()
        {
            DoMirrorOfTree(headNode);
        }

        private void DoMirrorOfTree(Node rootNode)
        {
            if(rootNode == null)
            {
                return;
            }
            else
            {
                Node temp = null;
                DoMirrorOfTree(rootNode.left);
                DoMirrorOfTree(rootNode.right);
                temp = rootNode.left;
                rootNode.left = rootNode.right;
                rootNode.right = temp;
            }
        }
    }
}
