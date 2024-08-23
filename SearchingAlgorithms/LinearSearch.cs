namespace AlgorithmImplementationsCSharp.SearchingAlgorithms;

public static class LinearSearch //Worst-case running time is O(n)
{

    public static int? Search(int[] values, int target)
    {
        for (var i = 0; i < values.Length; i++)
        {
            if (values[i] == target)
            {
                return i;
            }
        }

        return null;
    }
}
