namespace AlgorithmImplementationsCSharp.SortingAlgorithms;

public static class InsertionSort //Has a worst-case running time of O(n^2); best-case running time of Ω(n); i.e. worst-case is a quadratic function and best-case is a linear function
{
    public static void IterativeSort(int[] A, bool ascOrder = true) //Second parameter allows caller to specify whether they want asc or desc ordering (additional feature I added)
    {
        if (A.Length < 2) //Return array unmodified if length is less than two, otherwise an "index out of range" exception will be thrown below
        {
            return;
        }

        if (ascOrder)
        {
            for (var i = 1; i < A.Length; i++) //We start the index at the second element of the array (the first element can be considered as already sorted)
            {
                var key = A[i]; //Key represents the current item being sorted
                var j = i - 1; //J represents the various indexes of the already sorted items, which we iterate through to see where we should place "key"
                while (j > -1 && A[j] > key) //While there are sorted items to iterate through and the current sorted item has a value greater than the key, we move the sorted item by one position in the array
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = key; //Add the key (the current item we are ordering) into the correct position of the array
            }

            return;
        }

        for (var i = 1; i < A.Length; i++) //We start the index at the second element of the array (the first element can be considered as already sorted)
        {
            var key = A[i]; //Key represents the current item being sorted
            var j = i - 1; //J represents the various indexes of the already sorted items, which we iterate through to see where we should place "key"
            while (j > -1 && A[j] < key) //While there are sorted items to iterate through and the current sorted item has a value less than the key, we move the sorted item by one position in the array
            {
                A[j + 1] = A[j];
                j--;
            }
            A[j + 1] = key; //Add the key (the current item we are ordering) into the correct position of the array
        }
    }

    public static void RecursiveSort(int[] A, int n)
    {
        if (n <= 1)
        {
            return;
        }
        
        RecursiveSort(A, n - 1);
        
        var last = A[n - 1];
        var j = n - 2;
        
        while (j >= 0 && A[j] > last) 
        { 
            A[j + 1] = A[j]; 
            j--; 
        } 
        A[j + 1] = last;
    }
}