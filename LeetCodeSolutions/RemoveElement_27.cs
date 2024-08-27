namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class RemoveElement_27
{
    public static int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        byte nextIndexToModify = 0;
        
        foreach (var n in nums)
        {
            if (n != val)
            {
                nums[nextIndexToModify] = n;
                nextIndexToModify++;
                k++;
            }
        }

        return k;
    }
}