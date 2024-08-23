namespace AlgorithmImplementationsCSharp.SearchingAlgorithms;

public static class InversionSearch //Let A[0:n] be an array of n distinct numbers. If i < j and A[i] > A[j], then the pair (i, j) is called an inversion of A. This implementation is a modified merge sort, hence worst-case running time is 0(n log n)
{
    public static int Search(int[] values, int left, int right) //A[0:4]; 0; 4 - A[0:4]; 0; 2 - A[0:4]; 0; 1 - A[0:4]; 0; 0 - 
    {
        if (left >= right)
        {
            return 0;
        }
        
        var midPoint = left + (right - left) / 2; //2 - 1 - 0 - 
        var inversionsLeft = Search(values, left, midPoint); //A[0:4]; 0; 2 - A[0:4]; 0; 1 - A[0:4]; 0; 0; (returns 0) - 
        var inversionsRight =Search(values, midPoint + 1, right); //A[0:4]; 1; 1; 
        var inversionsMerge = MergeCount(values, left, midPoint, right);
        
        return inversionsLeft + inversionsRight + inversionsMerge;
    }

    private static int MergeCount(int[] values, int left, int midPoint, int right)
    {
        var leftTempArray = new int[midPoint - left + 1];
        var rightTempArray = new int[right - midPoint];
        var k = left;
        int i, j;
        var inversions = 0;
        
        for (i = 0; i < leftTempArray.Length; i++)
        {
            leftTempArray[i] = values[left + i];
        }

        for (j = 0; j < rightTempArray.Length; j++)
        {
            rightTempArray[j] = values[midPoint + 1 + j];
        }

        i = 0;
        j = 0;

        while (i < leftTempArray.Length && j < rightTempArray.Length)
        {
            if (leftTempArray[i] <= rightTempArray[j])
            {
                values[k] = leftTempArray[i];
                k++;
                i++;
            }
            else
            {
                values[k] = rightTempArray[j];
                k++;
                j++;
                inversions += midPoint + 1 - (left + i);
            }
        }

        while (i < leftTempArray.Length)
        {
            values[k] = leftTempArray[i];
            k++;
            i++;
        }

        while (j < rightTempArray.Length)
        {
            values[k] = rightTempArray[j];
            k++;
            j++;
        }

        return inversions;
    }
}