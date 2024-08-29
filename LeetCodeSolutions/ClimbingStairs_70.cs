namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class ClimbingStairs_70
{
    public static int ClimbStairs(int n) //This problem is better visualised as a decision tree
    {
        var a = 0;
        var b = 1;
        
        for(var i = 0; i < n; i++){
            var c = b + a;
            a = b;
            b = c;
        }
        return b;
    }
}