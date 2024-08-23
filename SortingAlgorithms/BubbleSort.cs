namespace AlgorithmImplementationsCSharp.SortingAlgorithms
{
    public static class BubbleSort //The worst-case running time for a Bubble Sort is O(n^2)
    {
        public static void Sort(int[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                for (var j = values.Length - 1; j > i; j--)
                {
                    if (values[j] < values[j - 1])
                    {
                        (values[j], values[j - 1]) = (values[j - 1], values[j]); //Instead of introducing a "temp" variable to swap the value at index j with the value at index j - 1, we can use tuples to swap via deconstruction
                    }
                }
            }
        }
    }
}
