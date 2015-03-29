using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BinarySearchTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void EvenLength8_ElementExists_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 4, 6, 7, 8, 10, 12, 14 };
            int pos = MathOperations.MathOperations.find(arr, 14);
            Assert.AreEqual(7, pos, "Found incorrectly");
        }

        [TestMethod]
        public void Length0_ElementNotExists_ReturnsMinusOne()
        {
            List<int> arr = new List<int> { };
            int pos = MathOperations.MathOperations.find(arr, 5);
            Assert.AreEqual(-1, pos, "Found incorrectly");
        }


        [TestMethod]
        public void Length3_LeftElement_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 2, 3 };
            int pos = MathOperations.MathOperations.find(arr, 1);
            Assert.AreEqual(0, pos, "Found incorrectly");
        }


        [TestMethod]
        public void Length3_MiddleElement_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 2, 3 };
            int pos = MathOperations.MathOperations.find(arr, 2);
            Assert.AreEqual(1, pos, "Found incorrectly");
        }

        [TestMethod]
        public void Length3_RightElement_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 2, 3 };
            int pos = MathOperations.MathOperations.find(arr, 3);
            Assert.AreEqual(2, pos, "Found incorrectly");
        }

        [TestMethod]
        public void Length4_RightElement_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 2, 3, 4 };
            int pos = MathOperations.MathOperations.find(arr, 1);
            Assert.AreEqual(0, pos, "Found incorrectly");
        }


        [TestMethod]
        public void EvenLength10_ElementExists_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 4, 6, 7, 8, 10, 12, 14, 15, 18 };
            int pos = MathOperations.MathOperations.find(arr, 7);
            Assert.AreEqual(3, pos, "Found incorrectly");
        }

        [TestMethod]
        public void OddLength9_ElementExists_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 4, 6, 7, 8, 10, 12, 14, 15 };
            int pos = MathOperations.MathOperations.find(arr, 10);
            Assert.AreEqual(5, pos, "Found incorrectly");
        }



        [TestMethod]
        public void OddLength7_ElementExists_ReturnsPosition()
        {
            List<int> arr = new List<int> { 1, 4, 6, 7, 8, 10, 12 };
            int pos = MathOperations.MathOperations.find(arr, 10);
            Assert.AreEqual(5, pos, "Found incorrectly");
        }

        [TestMethod]
        public void Length1_ElementExists_ReturnsPosition()
        {
            List<int> arr = new List<int> { 5 };
            int pos = MathOperations.MathOperations.find(arr, 5);
            Assert.AreEqual(0, pos, "Found incorrectly");
        }
    }
}
