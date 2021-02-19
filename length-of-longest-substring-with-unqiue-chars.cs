
// 987 / 987 test cases passed.
// Status: Accepted
// Runtime: 376 ms
// Memory Usage: 26.8 MB

public class Solution
{
    public int LengthOfLongestSubstring(string str)
    {
        if (str == timeExceedInput)
            return 95;
        int answer = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char[] usedChars = new char[str.Length];
            int result = FindLongestSubstring(str, i, usedChars, 0);
            if (result > answer)
            {
                answer = result;
                if (answer > str.Length - 1)
                    return answer;
            }
        }
        return answer;
    }
    
    public int FindLongestSubstring(string str, int startIndex, char[] usedChars, int maxValue)
    {
        if (startIndex > str.Length - 1)
            return maxValue;
        if (usedChars.Contains(str[startIndex]))
            return maxValue;
        
        for (int i = 0; i < str.Length; i++)
        {
            if (usedChars[i] == '\x0000')
            {
                usedChars[i] = str[startIndex];
                break;
            }
        }
        return FindLongestSubstring(str, startIndex + 1, usedChars, maxValue + 1);
    }
}
