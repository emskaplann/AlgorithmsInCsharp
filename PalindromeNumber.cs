// Runtime: 68 ms, faster than 59.53% of C# online submissions for Palindrome Number.
// Memory Usage: 16.9 MB, less than 45.68% of C# online submissions for Palindrome Number.
// Link: https://leetcode.com/problems/palindrome-number/

public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
        int midIndex = s.Length / 2;
        for (int i = 0, j = s.Length - 1; i < midIndex; i++, j--)
        {
            if (s[i] != s[j]) return false;
        }
        return true;
    }
}
