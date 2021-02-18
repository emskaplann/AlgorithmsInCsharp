using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args)
  {
      // Capitalize Each Word
      Console.WriteLine(CapitalizeEachWord("emirhan melik sencer"));

      // Merge Sort
      int[] numbers = {99, 44, 6, 2, 1, 5, 87, 283, 4, 0};
      numbers = MergeSort(numbers);
      foreach (int num in numbers)
      {
          Console.Write($"{num} ");
      }
      Console.WriteLine();
      
  }

  public static string CapitalizeEachWord(string str)
  {
      string[] splittedString = str.Split(' ');
      for (int i = 0; i < splittedString.Length; i++)
      {
          char[] splittedWord = splittedString[i].ToCharArray();
          splittedWord[0] = char.ToUpper(splittedWord[0]);
          splittedString[i] = string.Join("", splittedWord);
      }
      return string.Join(" ", splittedString);
  }

  public static int[] MergeSort(int[] list)
  {
      int length = list.Length;

      if (length == 1)
          return list;
      int middleIdx = length / 2;
      int[] leftList = list.Take(middleIdx).ToArray();
      int[] rightList = list.Skip(middleIdx).ToArray();

      return Merge(
          MergeSort(leftList),
          MergeSort(rightList)
      );
  }

  private static int[] Merge(int[] leftList, int[] rightList)
  {
      int[] result = new int[0];
      int leftIdx = 0;
      int rightIdx = 0;

      while (leftIdx < leftList.Length && rightIdx < rightList.Length)
      {
          if(leftList[leftIdx] < rightList[rightIdx])
          {
              Array.Resize(ref result, result.Length + 1);
              result[result.GetUpperBound(0)] = leftList[leftIdx];
              leftIdx++;
          }
          else
          {
              Array.Resize(ref result, result.Length + 1);
              result[result.GetUpperBound(0)] = rightList[rightIdx];
              rightIdx++;
          }
      }
      int[] z = new int[result.Length + leftList.Length - leftIdx + rightList.Length - rightIdx];
      result.CopyTo(z, 0);
      leftList.Skip(leftIdx).ToArray().CopyTo(z, result.Length);
      rightList.Skip(rightIdx).ToArray().CopyTo(z, result.Length + leftList.Skip(leftIdx).ToArray().Length);
      return z;
  }
}
