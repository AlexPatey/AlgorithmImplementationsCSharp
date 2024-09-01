using AlgorithmImplementationsCSharp.LeetCodeSolutions;
using AlgorithmImplementationsCSharp.SortingAlgorithms;

var result = SingleNumber_136.SingleNumber([4, 1, 2, 1, 2]);

Console.ReadLine();
return;

static void PrintAll<T>(IEnumerable<T> input)
{
    foreach (var item in input)
    {
        Console.WriteLine(item);
    }
}