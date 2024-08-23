namespace AlgorithmImplementationsCSharp.SortingAlgorithms;

public static class SelectionSort //Has a worst-case running time of O(n^2); best-case running time of Ω(n^2)
{
    public static void Sort(int[] A)
    {
        for (var i = 0; i < A.Length - 1; i++) //We can afford to loop n - 1 times because the last element is necessarily sorted by the time we complete the n - 1 loop
        {
            var minIndex = i;
            for (var j = i + 1; j < A.Length; j++) //We can set j = i + 1 to prevent checking if A[i] is less than itself, which will of course never be the case
            {
                if (A[j] < A[minIndex])
                {
                    minIndex = j;
                }
            }
            (A[i], A[minIndex]) = (A[minIndex], A[i]);
        }
    }
}

/*  Pseudocode:
 *
 *  input: A[0:n-1]
 * 
 *  for i = 0 to n - 2
 *      minIndex = i
 *      for j = i + 1 to n - 1
 *          we need to find the smallest element out of this second loop!
 *          if (A[j] < A[minIndex]
 *              minIndex = j
 *      temp = A[minIndex]
 *      A[minIndex] = A[i]
 *      A[i] = temp
 *            
 */