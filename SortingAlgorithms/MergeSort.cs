using System.Reflection;

namespace AlgorithmImplementationsCSharp.SortingAlgorithms
{
    public static class MergeSort //The worst-case running time for a Merge Sort is O(n lg n)
    {
        public static void Sort(int[] values, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            
            var midPoint = left + (right - left) / 2; //Determining the mid-point represents the "divide" step of the "divide, conquer, combine" sort pattern that the merge sort is an instance of
            Sort(values, left, midPoint); //The Sort calls represent the "conquer" step of the "divide, conquer, combine" sort pattern
            Sort(values, midPoint + 1, right);
            Merge(values, left, midPoint, right); //The call to Merge represents the "combine" step of the "divine, conquer, combine" sort pattern
        }

        private static void Merge(int[] values, int left, int midPoint, int right) //The Merge method assumes that values[left:midPoint] and values[midPoint+1:right] are already sorted; this method runs in θ(n)
        {
            var leftTempArray = new int[midPoint - left + 1];
            var rightTempArray = new int[right - midPoint];
            var k = left; //K represents the index of the value being filled
            int i, j; //I and J represent the indexes of the smallest remaining values in the left and right values arrays, respectively

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
                if (leftTempArray[i] <= rightTempArray[j]) //Copy the next smallest unmerged element back into the values array
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
        }
    }
}
