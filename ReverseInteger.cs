// Runtime: 36 ms, faster than 96.56% of C# online submissions for Reverse Integer.
// Memory Usage: 15.7 MB, less than 17.69% of C# online submissions for Reverse Integer.
// Link: https://leetcode.com/problems/reverse-integer/

public class Solution
{
    public int Reverse(int x)
    {
        StringBuilder result = new StringBuilder();
        int lastDigit;
        
        if (x > 0)
        {
            while (x > 0)
            {
                lastDigit = x % 10;
                x = x / 10;
                result.Append(lastDigit.ToString());
            }
            int intResult;
            bool success = Int32.TryParse(result.ToString(), out intResult);

            return success ? intResult : 0;   
        }
        else
        {
            int index = 0;
            while (x < 0)
            {
                lastDigit = x % 10;
                x = x / 10;
                if (lastDigit == 0 && index == 0) continue;
                if (index > 0) lastDigit = Math.Abs(lastDigit);
                result.Append(lastDigit.ToString());
                index++;
            }
            int intResult;
            bool success = Int32.TryParse(result.ToString(), out intResult);

            return success ? intResult : 0;  
        }
    }
}
