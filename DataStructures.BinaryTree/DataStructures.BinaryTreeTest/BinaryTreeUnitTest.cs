using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void CanTraverseInOrder()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Insert(10);
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(7);
            binaryTree.Insert(100);
            var actualResult = binaryTree.GetInOrderTraversal();
            var expectedResult = new List<int>() { 7,10,30,50,100};
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CanTraversePreOrder()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Insert(10);
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(7);
            binaryTree.Insert(100);
            var actualResult = binaryTree.GetPreOrderTraversal();
            var expectedResult = new List<int>() { 10,7,50,30,100};
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CanTraversePostOrder()
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Insert(10);
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(7);
            binaryTree.Insert(100);
            var actualResult = binaryTree.GetPostOrderTraversal();
            var expectedResult = new List<int>() { 7, 30, 100, 50, 10 };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
