92 / 176 test cases passed.
Status: Time Limit Exceeded.
Link: https://leetcode.com/problems/longest-palindromic-substring/

public class Solution
{
    public string LongestPalindrome(string str)
    {
        if (str.Length == 1)
            return str;
        int maxValue = 0;
        string maxString = "";
        for (int i = 0; i < str.Length; i++)
        {
            string substr = FindLongestPalindrome(str, i, 1);
            if (substr.Length > maxValue && IsPalindromic(substr))
            {
                maxValue = substr.Length;
                maxString = substr;
            }
        }
        return maxString;
    }
    
    public string FindLongestPalindrome(string str, int startIndex, int endIndex)
    {
        if (endIndex + startIndex > str.Length)
        {
            return str.Substring(startIndex, endIndex - 1);   
        }
        
        if (!IsPalindromic(str.Substring(startIndex, endIndex)) && !FindIfFutureSubstringsArePalindrome(str, startIndex, endIndex))
            return str.Substring(startIndex, endIndex - 1);
        
        return FindLongestPalindrome(str, startIndex, endIndex + 1);
    }
    
    public bool FindIfFutureSubstringsArePalindrome(string str, int startIndex, int endIndex)
    {
        if (endIndex + startIndex > str.Length)
            return false;
        
        if (IsPalindromic(str.Substring(startIndex, endIndex)))
            return true;
        
        return FindIfFutureSubstringsArePalindrome(str, startIndex, endIndex + 1);
    }
    
    public bool IsPalindromic(string str)
    {
        int midIndex = str.Length / 2;
        if (str.Length % 2 == 0)
        {
            for (int i = 0, j = str.Length - 1; i < midIndex; i++, j--)
            {
                if (str[i] != str[j])
                    return false;
            }
        }
        else
        {   
            for (int i = 0, j = str.Length - 1; i < midIndex; i++, j--)
            {
                if (str[i] != str[j])
                    return false;
            }
        }
        return true;
    }
}
