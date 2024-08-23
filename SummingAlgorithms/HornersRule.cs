namespace AlgorithmImplementationsCSharp.SummingAlgorithms;

public static class HornersRule
{
    public static int Evaluate(int[] A, int x) //A[0:n] represents coefficients a_0, a_1, ... a_n; x is the variable of the polynomial; Worst-case running time is O(n)
    {
        var p = 0;
        for (var i = A.Length - 1; i >= 0 ; i--)
        {
            p = A[i] + x * p;
        }
        
        return p;
    }
}