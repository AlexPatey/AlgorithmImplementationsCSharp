namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class Sqrt_69
{
    public static int MySqrt(int x)
    {
        int l = 0, r = x;
        
        while (l < r) 
        {
            var mid = (l + r + 1) >>> 1;
            
            if (mid > x / mid) 
            {
                r = mid - 1;
            } 
            else 
            {
                l = mid;
            }
        }
        return l;
    }  
}