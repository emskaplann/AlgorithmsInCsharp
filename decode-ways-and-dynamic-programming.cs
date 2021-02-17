using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
			// Decode Ways
			Console.WriteLine(DecodeWays("214"));
		
			// Product Defects(dynamic programming)
			int[,] samples = new int[3, 3] {
				{ 1, 0, 1},
				{ 1, 1, 0},
				{ 1, 1, 0},
			};
			Console.WriteLine(LargestArea(samples));
	}
	
	// Helper method for FindNewValue
	public static int TryGetElement(ref int[,] matrix, int indexRow, int indexCol, int defaultValue)
	{
	  if ((indexRow != -1 && indexCol != -1) && (indexRow < matrix.GetLength(0) && indexCol < matrix.GetLength(1)))
	  {
		return matrix[indexRow, indexCol];
	  }
	  return defaultValue;
	}
	
	// Helper method for Product Defects
	public static int FindNewValue(int row, int col, ref int[,] matrix)
	{
		int[] neighbours = {
						TryGetElement(ref matrix, row, col - 1, 0),
						TryGetElement(ref matrix, row - 1, col, 0),
						TryGetElement(ref matrix, row - 1, col - 1, 0),
					};
		
		return neighbours.Min() + 1;
	}
	
	// Product Defects(dynamic programming)
	static int LargestArea(int[,] samples)
	{
		int[,] newMatrix = samples.Clone() as int[,];
		int answer = 0;
		
		for (int row = 0; row < newMatrix.GetLength(0); row++)
		{
			for (int col = 0; col < newMatrix.GetLength(1); col++)
			{
				if (samples[row, col] == 0)
				{
					newMatrix[row, col] = 0;
				}
				else if (samples[row, col] == 1)
				{
					newMatrix[row, col] = FindNewValue(row, col, ref samples);
					if (newMatrix[row, col] > answer)
					{
						answer = newMatrix[row, col];
					}
				}
			}
		}
		return answer;
	}
	
	// Decode Ways
	static int DecodeWays(string str)
	{
		// Base case
		if (str[0] == '0')
		{
			return 0;
		}
		
		switch (str.Length)
		{
			case 1:
				return 1;
			case 2:
				if (Int32.Parse(str) > 26)
				{
					return str[1] == '0' ? 0 : 1;
				}
				else
				{
					return str[1] == '0' ? 1 : 2;
				}
			default:
				if (Int32.Parse(str.Substring(0, 2)) > 26)
				{
					return DecodeWays(str.Substring(1, str.Length - 1));
				}
				else
				{
					// Console.WriteLine(str);
					return DecodeWays(str.Substring(1)) + DecodeWays(str.Substring(2));
				}
		}
	}
}
