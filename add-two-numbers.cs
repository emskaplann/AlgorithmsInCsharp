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
        
        long result = long.Parse(Reverse(l1Values.ToString())) + long.Parse(Reverse(l2Values.ToString()));

        long currentDigit = result % 10;
        result = result / 10;
        
        if (result < 1)
            return new ListNode(Convert.ToInt32(currentDigit));
        
        ListNode headOfList = new ListNode(Convert.ToInt32(currentDigit), new ListNode());
        ListNode currentNode = headOfList.next;
        while (result >= 10)
        {
            currentDigit = result % 10;
            result = result / 10;
            
            currentNode.val = Convert.ToInt32(currentDigit);
            currentNode.next = new ListNode();
            currentNode = currentNode.next;
        }
        currentNode.val = Convert.ToInt32(result);
        return headOfList;
    }
    
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
