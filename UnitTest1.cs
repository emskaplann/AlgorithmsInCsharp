using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsInCsharpNS;
using System.Collections.Generic;

namespace AlgorithmsInCsharpTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseAlgo_ReversesString()
        {
            string testStr = "Example string.";
            string expected = ".gnirts elpmaxE";

            string result = AlgorithmsInCsharp.ReverseStringIteratively(testStr);
            string result2 = AlgorithmsInCsharp.ReverseStringRecursively(testStr);

            Assert.AreEqual(expected, result, false, "*Iterative* solution for reversing a string is not succesful.");
            Assert.AreEqual(expected, result2, false, "*Recursive* solution for reversing a string is not succesful.");
        }

       [TestMethod]
       public void GetSumBetweenNumbers_RecursivelyFindSum()
        {
            int min = 3;
            int max = 7;
            int expected = 25;

            int result = AlgorithmsInCsharp.GetSumBetweenNumbersRecursively(min, max);

            Assert.AreEqual(expected, result, 0.001, "GetSumBetweenNumbers solution doesn't work as expected.");
        }

        [TestMethod]
        public void XToTheYPower_FindsYthPowerOfX()
        {
            int x = 2;
            int y = 3;
            int expected = 8;

            int result = AlgorithmsInCsharp.XToTheYPower(x, y);

            Assert.AreEqual(expected, result, 0.001, "XToTheYPower function does not return expected value.");
        }

        [TestMethod]
        public void MultiplyList_ReturnsNewListWithSquaresOfElements()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };
            List<int> expected = new List<int>() { 1, 4, 9 };

            List<int> result = AlgorithmsInCsharp.MultiplyList(numbers);

           CollectionAssert.AreEqual(expected, result, "MultiplyList does not return the expected list.");
        }

        [TestMethod]
        public void FillRoomWithBoxes_UsesGreddyAlgoToFillOutBlanks()
        {
            int roomSize = 25;
            List<int> possibleSizes = new List<int>() { 7, 3, 1 };
            List<int> boxes = new List<int>();

            List<int> expected = new List<int>() { 7, 7, 7, 3, 1 };

            List<int> result = AlgorithmsInCsharp.FillRoomWithBoxes(roomSize, possibleSizes, boxes);

            CollectionAssert.AreEqual(expected, result, "FillRoomWithBoxes does not return the expected list.");
        }
    }
}
