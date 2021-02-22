// Runtime: 104 ms, faster than 55.51% of C# online submissions for ZigZag Conversion.
// Memory Usage: 37.6 MB, less than 9.62% of C# online submissions for ZigZag Conversion.
// Link: https://leetcode.com/problems/zigzag-conversion/

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (s.Length == 1 || s.Length == 2 || numRows == 1 || s.Length == numRows) return s;
        int oneColCost = (2 * numRows) - 2;
        int fullSection = (s.Length / oneColCost);
        int halfSection = ((s.Length % oneColCost) % numRows) + 1;
        int numCols = (fullSection * (numRows - 1)) + halfSection;
        Console.WriteLine(numCols);
        char[,] zigZag = new char[numRows, numCols];
        
        for (int i = 0; i < numRows; i++)
        {
            for (int j = i, k = 0; j < s.Length; j += oneColCost, k += (numRows - 2) + 1)
            {
                zigZag[i, k] = s[j];
            }
        }
        
        for (int i = numRows - 2, o = 1; i > 0; i--, o++)
        {
            for (int j = i + 2 * o, k = o; j < s.Length; j += oneColCost, k += (numRows - 2) + 1)
            {
                zigZag[i, k] = s[j];
            }
        }
        
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                if (zigZag[i, j] != '\0') result.Append(zigZag[i, j]);
            }
        }
        return result.ToString();
        
        // If you want to print the matrix uncomment below.
        // for (int i = 0; i < numRows; i++)
        // {
        //     for (int j = 0; j < numCols; j++)
        //     {
        //         if (zigZag[i, j] == '\0') zigZag[i, j] = '.';
        //         Console.Write(string.Format("{0} ", zigZag[i, j]));
        //     }
        //     Console.Write(Environment.NewLine + Environment.NewLine);
        // }
    }
}
