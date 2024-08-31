namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class PartitioningIntoMinumumNumberOfDeciBinaryNumbers_1689
{
    public static int MinPartitions(string n)
    {
        var arr = n.ToCharArray();
        Array.Sort(arr);
        return(int.Parse(arr[^1].ToString()));
    }
}