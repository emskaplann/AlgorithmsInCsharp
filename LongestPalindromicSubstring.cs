// 176 / 176 test cases passed.
// Stats: Time Limit Exceeded.
// Link: https://leetcode.com/problems/longest-palindromic-substring/

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        string answer = "";
        
        if (n == 0) return s;
        if (n == 1) return s;
        
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                string substr = s.Substring(i, j);
                if (substr.Length < answer.Length) continue;
                if (IsPalindromic(substr))
                {
                    answer = substr;
                }
            }
        }
        return answer;
    }
    
    public bool IsPalindromic(string str)
    {
        int midIndex = str.Length / 2;
        for (int i = 0, j = str.Length - 1; i < midIndex; i++, j--)
        {
            if (str[i] != str[j])
                return false;
        }
        return true;
    }
}
