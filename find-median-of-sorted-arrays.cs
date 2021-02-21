// Runtime: 120 ms, faster than 79.54% of C# online submissions for Median of Two Sorted Arrays.
// Memory Usage: 28.5 MB, less than 46.18% of C# online submissions for Median of Two Sorted Arrays.
// Link: https://leetcode.com/problems/median-of-two-sorted-arrays/

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // 1 - merge arrays
        // 2 - find median of the merged array
        int[] mergedArray = new int[nums1.Length + nums2.Length];
        int maIndex = 0;
        int faIndex = 0;
        int saIndex = 0;
        for (int i = 0; i < mergedArray.Length; i++)
        {
            int numToAdd = 0;
            if (faIndex > nums1.Length - 1)
            {
                numToAdd = nums2[saIndex];
                saIndex++;
            }
            else if (saIndex > nums2.Length - 1)
            {
                numToAdd = nums1[faIndex];
                faIndex++;
            }
            else
            {
                if (nums1[faIndex] < nums2[saIndex])
                {
                    numToAdd = nums1[faIndex];
                    faIndex++;
                }
                else
                {
                    numToAdd = nums2[saIndex];
                    saIndex++;
                }
            }
            mergedArray[maIndex] = numToAdd;
            maIndex++;
        }
        double answer = 0;
        if (mergedArray.Length % 2 == 0)
        {
            int midIndex = mergedArray.Length / 2;
            answer = ((double) mergedArray[midIndex] + (double) mergedArray[midIndex - 1]) / (double) 2;
        }
        else
        {
            int midIndex = mergedArray.Length / 2;
            answer = mergedArray[midIndex];
        }
        return answer;
    }
}
