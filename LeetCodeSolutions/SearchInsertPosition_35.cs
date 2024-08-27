namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class SearchInsertPosition_35
{
    public static int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        if (target < nums[0])
        {
            return 0;
        }
        
        if (target > nums[^1])
        {
            return nums.Length;
        }
        
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left++;
    }
}