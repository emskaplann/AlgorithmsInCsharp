/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
// Problem link: https://leetcode.com/problems/add-two-numbers/
// Runtime: 100 ms, faster than 92.95% of C# online submissions for Add Two Numbers.
// Memory Usage: 28.3 MB, less than 65.14% of C# online submissions for Add Two Numbers.

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        StringBuilder l1Values = new StringBuilder();
        StringBuilder l2Values = new StringBuilder();
        
        while (l1.next != null)
        {
            l1Values.Append(l1.val.ToString());
            l1 = l1.next;
        }
        while (l2.next != null)
        {
            l2Values.Append(l2.val.ToString());
            l2 = l2.next;
        }
        l1Values.Append(l1.val.ToString());
        l2Values.Append(l2.val.ToString());
        
        var result = BigInteger.Parse(Reverse(l1Values.ToString())) + BigInteger.Parse(Reverse(l2Values.ToString()));

        var currentDigit = result % 10;
        result = result / 10;
        
        if (result < 1)
            return new ListNode((int) currentDigit);
        
        ListNode headOfList = new ListNode((int) currentDigit, new ListNode());
        ListNode currentNode = headOfList.next;
        while (result >= 10)
        {
            currentDigit = result % 10;
            result = result / 10;
            
            currentNode.val = (int) currentDigit;
            currentNode.next = new ListNode();
            currentNode = currentNode.next;
        }
        currentNode.val = (int) result;
        return headOfList;
    }
    
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
