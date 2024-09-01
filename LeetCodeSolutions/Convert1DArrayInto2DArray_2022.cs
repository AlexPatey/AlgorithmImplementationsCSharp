namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class Convert1DArrayInto2DArray_2022
{
    public static int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (m * n != original.Length)
        {
            return [];
        }
        
        var result = new int[m][];

        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                result[i][j] = original[i * n + j];
            }
        }
        
        return result;
    }
}