namespace AlgorithmImplementationsCSharp.SortingAlgorithms;

public static class HeapSort
{
    public static void Sort(Heap heap, bool asc = true) 
    {
        if (asc)
        {
            BuildMaxHeap(heap);
        }
        else
        {
            BuildMinHeap(heap);
        }

        for (var i = heap.A.Length - 1; i >= 1; i--)
        {
            (heap.A[0], heap.A[i]) = (heap.A[i], heap.A[0]);
            heap.heapSize--;
            if (asc)
            {
                MaxHeapify(heap, 0);    
            }
            else
            {
                MinHeapify(heap, 0);
            }
        }
    }
    
    private static void BuildMaxHeap(Heap heap) //Creates a max heap from an unsorted array
    {
        heap.heapSize = heap.A.Length - 1;
        for (var i = (heap.A.Length - 1) / 2; i >= 0 ; i--)
        {
            MaxHeapify(heap, i);
        }
    } 
    
    private static void BuildMinHeap(Heap heap)
    {
        heap.heapSize = heap.A.Length - 1;
        for (var i = (heap.A.Length - 1) / 2; i >= 0 ; i--)
        {
            MinHeapify(heap, i);
        }
    } 
    
    private static void MaxHeapify(Heap heap, int i)
    {
        var left = Left(i);
        var right = Right(i);
        int largest;
        
        if (left <= heap.heapSize && heap.A[left] > heap.A[i])
        {
            largest = left;
        }
        else
        {
            largest = i;
        }

        if (right <= heap.heapSize && heap.A[right] > heap.A[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            (heap.A[i], heap.A[largest]) = (heap.A[largest], heap.A[i]);
            MaxHeapify(heap, largest);
        }
    }
    
    private static void MinHeapify(Heap heap, int i)
    {
        var left = Left(i);
        var right = Right(i);
        int smallest;
        
        if (left <= heap.heapSize && heap.A[left] < heap.A[i])
        {
            smallest = left;
        }
        else
        {
            smallest = i;
        }

        if (right <= heap.heapSize && heap.A[right] < heap.A[smallest])
        {
            smallest = right;
        }

        if (smallest != i)
        {
            (heap.A[i], heap.A[smallest]) = (heap.A[smallest], heap.A[i]);
            MinHeapify(heap, smallest);
        }
    }
    
    private static int Parent(int i) => i / 2;
    
    private static int Left(int i) => 2 * i;
    
    private static int Right(int i) => 2 * i + 1;

    public class Heap
    {
        public int[] A { get; set; }
        public int heapSize { get; set; }
    }
}