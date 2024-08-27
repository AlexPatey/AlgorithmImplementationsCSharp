namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class RemoveDuplicatesFromSortedArray_26
{
    public static int RemoveDuplicates(int[] nums)
    {
        var numsSet = new HashSet<int>();

        foreach (var n in nums)
        {
            numsSet.Add(n);
        }

        for (var i = 0; i < numsSet.Count; i++)
        {
            nums[i] = numsSet.ElementAt(i);
        }

        return numsSet.Count;
    }
}