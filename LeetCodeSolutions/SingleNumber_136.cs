namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class SingleNumber_136
{
    public static int SingleNumber(int[] nums)
    {
        var result = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            result ^= nums[i];
        }
        
        return result;
    }
}