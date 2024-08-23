namespace AlgorithmImplementationsCSharp.SearchingAlgorithms;

public static class BinarySearch //The worst-case running time is O(log n).
{
    public static int? IterativeSearch(int[] A, int target)
    {
        var left = 0;
        var right = A.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (A[mid] == target)
            {
                return mid;
            }

            if (A[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return null;
    }
    
    public static int? RecursiveSearch(int[] A, int target, int left, int right) 
    {
        if (left > right)
        {
            return null;
        }
        
        var mid = (left + right) / 2;
        
        if (A[mid] == target)
        {
            return mid;
        }

        return A[mid] < target ? RecursiveSearch(A, target, mid + 1, right) : RecursiveSearch(A, target, left, mid - 1);
    }   
}

/*

    Pseudocode for Recursive Version
    
    

*/