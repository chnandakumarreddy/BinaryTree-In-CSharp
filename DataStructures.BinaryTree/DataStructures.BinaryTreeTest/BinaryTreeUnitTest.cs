using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.BinaryTree
{
    [TestClass]
    public class BinaryTreeUnitTest
    {
        [TestMethod]
        public void CanInsertIntoBinaryTree()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Insert(10);
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(7);
            binaryTree.Insert(100);
            Assert.IsTrue(binaryTree.Count == 5);
        }

        [TestMethod]
        public void CanSearchBinaryTree()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Insert(10);
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(7);
            binaryTree.Insert(100);
            var result = binaryTree.SearchBinaryTree(7);
            Assert.IsTrue(result.data == 7);
        }

        [TestMethod]
        public void CanGetBinaryTreeDepth()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Insert(10);
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(7);
            binaryTree.Insert(100);
            var result = binaryTree.GetTreeDepth();
            Assert.IsTrue(result == 3);
        }
    }
}
