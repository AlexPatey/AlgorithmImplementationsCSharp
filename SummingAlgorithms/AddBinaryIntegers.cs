namespace AlgorithmImplementationsCSharp.SummingAlgorithms;

public static class AddBinaryIntegers
{
    public static int[] Add(int[] binaryInteger1, int[] binaryInteger2)
    {
        var isCarryOver = false;
        var binaryIntegerSum = new int[binaryInteger1.Length + 1];
        
        for (var i = binaryInteger1.Length - 1; i >= 0 ; i--)
        {
            var result = binaryInteger1[i] + binaryInteger2[i];
            
            if (!isCarryOver)
            {
                if (result == 2)
                {
                    binaryIntegerSum[i + 1] = 0;
                    isCarryOver = true;
                }
                else
                {       
                    binaryIntegerSum[i + 1] = result;
                }
            }
            else
            {
                if (result == 0)
                {
                    binaryIntegerSum[i + 1] = 1;
                    isCarryOver = false; 
                }
                else
                {
                    binaryIntegerSum[i + 1] = result - 1; 
                }
            }
        }

        if (isCarryOver)
        {
            binaryIntegerSum[0] = 1;
        }
        
        return binaryIntegerSum;
    }
}