// Runtime: 448 ms, faster than 5.53% of C# online submissions for String to Integer (atoi).
// Memory Usage: 30 MB, less than 6.07% of C# online submissions for String to Integer (atoi).
// Link: https://leetcode.com/problems/string-to-integer-atoi/

// It could be the worst solution ever but still it's a solution :). I will try to improve this solution.

public class Solution
{
    public int MyAtoi(string s)
    {   
        s = s.Trim();
        if (s == "") return 0;
        double answer = 0;
        double multiplyWith = 1;
        int multiplyCount = 0;
        bool isNegative;
        int startIndex = 0;
        
        if (s[0] == '-')
        {
            isNegative = true;
            startIndex++;
        }
        else if (s[0] == '+') 
        {
            isNegative = false;
            startIndex++;
        }
        else
        {
            isNegative = false;
        }
        
        for (int i = s.Length - 1; i >= startIndex; i--)
        {
            if (!IsNumeric(s[i])) ResetVars(ref answer, ref multiplyCount, ref multiplyWith);
            if (!IsNumeric(s[i]) && answer > 0)
            {
                if (IsNumeric(s[i+1]))
                {
                    ResetVars(ref answer, ref multiplyCount, ref multiplyWith);
                    continue;
                }
                return 0;
            }
            if (!IsNumeric(s[i]) || s[i] == ' ') continue;
            
            answer += ((double) ToInt(s[i]) * multiplyWith);
            multiplyWith *= 10;
        }
        answer = Math.Abs(answer);
        if (isNegative) answer *= -1;
        if (answer > int.MaxValue) return int.MaxValue;
        else if (answer < int.MinValue) return int.MinValue;
        return (int) answer;
    }

    
    public void ResetVars(ref double x, ref int y, ref double z)
    {
        x = 0;
        y = 0;
        z = 1;
    }
    
    public int ToInt(char c)
    {
        return (int)(c - '0');
    }
    
    public static bool IsNumeric(char a)
    {
        System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(@"^[0-9]*$");
        return rg.IsMatch(a.ToString());
    }
}
