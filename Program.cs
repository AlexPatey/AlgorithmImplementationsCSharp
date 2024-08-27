using AlgorithmImplementationsCSharp.SortingAlgorithms;

var heap = new HeapSort.Heap
{
    A = [16, 14, 10, 8, 7, 9, 3, 2, 4, 1]
};

HeapSort.Sort(heap, false);

Console.ReadLine();