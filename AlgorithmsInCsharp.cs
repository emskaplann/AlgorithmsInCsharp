using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsInCsharpNS
{
    public class AlgorithmsInCsharp
    {
        public static void Main(string[] args)
        {
            // Algorithms and Data Structures in C#

            // Brute force (linear search)
            Console.WriteLine(IsFirstCharRepeated("Example string."));
            Console.WriteLine();

            // Iterative Reverse
            Console.WriteLine(ReverseStringIteratively("Example string."));
            Console.WriteLine();

            // Recursive Reverse
            Console.WriteLine(ReverseStringRecursively("Example string."));
            Console.WriteLine();

            // Recursive GetSumBetweenNumbers
            Console.WriteLine(GetSumBetweenNumbersRecursively(3, 7));
            Console.WriteLine();

            // Recursive XToTheYPower
            Console.WriteLine(XToTheYPower(2, 3));
            Console.WriteLine();

            // Divide-and-conquer
            List<int> numbers = new List<int>() { 1, 2, 3 };
            MultiplyList(numbers).ForEach(Console.Write);
            Console.WriteLine();
            Console.WriteLine();

            // Greedy
            int roomSize = 25;
            List<int> possibleSizes = new List<int>() { 7, 3, 1 };
            List<int> boxes = new List<int>();
            FillRoomWithBoxes(roomSize, possibleSizes, boxes).ForEach(Console.Write);
            Console.WriteLine();
            Console.WriteLine();
        }

        public static List<int> FillRoomWithBoxes(int roomSize, List<int> possibleSizes, List<int> boxes)
        {
            if (roomSize == 0)
            {
                return boxes;
            }

            for (int i = 0; i < possibleSizes.Count; i++)
            {
                if (roomSize >= possibleSizes[i])
                {
                    boxes.Add(possibleSizes[i]);
                    return FillRoomWithBoxes(roomSize - possibleSizes[i], possibleSizes, boxes);
                }
            }

            return new List<int>();
        }

        public static List<int> MultiplyList(List<int> numbers)
        {
            if (numbers.Count == 1)
            {
                return new List<int>() { numbers[0] * numbers[0] };
            }

            int middleIndex = numbers.Count / 2;
            List<int> firstHalf = numbers.GetRange(0, middleIndex);
            List<int> secondHalf = numbers.GetRange(middleIndex, numbers.Count - 1);

            return MultiplyList(firstHalf).Concat(MultiplyList(secondHalf)).ToList();
        }

        public static int XToTheYPower(int x, int y)
        {
            if (y == 1)
                return x;
            return x * XToTheYPower(x, y - 1);
        }

        public static int GetSumBetweenNumbersRecursively(int min, int max)
        {
            if (max == min)
                return min;
            return max + GetSumBetweenNumbersRecursively(min, max - 1);
        }

        public static string ReverseStringRecursively(string str)
        {
            if (str.Length == 1)
                return str;
            return str[str.Length - 1] + ReverseStringRecursively(str.Remove(str.Length - 1));
        }

        public static string ReverseStringIteratively(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                newStr = newStr + str[i];
            }
            return newStr;
        }

        public static bool IsFirstCharRepeated(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[0].ToString().ToUpper() == str[i].ToString().ToUpper())
                    return true;
            }
            return false;
        }
    }
}