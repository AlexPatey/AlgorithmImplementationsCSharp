namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class MergeSortedArray_88
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var sortedNums = new int[n + m];
        var i = 0;
        var j = 0;
        var k = 0;

        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            {
                sortedNums[k] = nums1[i];
                i++;
            }
            else
            {
                sortedNums[k] = nums2[j];
                j++;
            }

            k++;
        }

        while (i < m)
        {
            sortedNums[k] = nums1[i];
            i++;
            k++;
        }
        
        while (j < n)
        {
            sortedNums[k] = nums2[j];
            j++;
            k++;
        }

        for (var l = 0; l < sortedNums.Length; l++)
        {
            nums1[l] = sortedNums[l];
        }
    }
}