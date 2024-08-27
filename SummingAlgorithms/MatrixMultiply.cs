using System.Runtime.InteropServices;

namespace AlgorithmImplementationsCSharp.SummingAlgorithms;

public static class MatrixMultiply
{
    public static int[,] IterativeSolve(int[,] A, int[,] B)
    {
        var n = (int)Math.Sqrt(A.Length);
        var C = new int[n, n]; 
        
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                for (var k = 0; k < n; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        return C;
    }
    
}
