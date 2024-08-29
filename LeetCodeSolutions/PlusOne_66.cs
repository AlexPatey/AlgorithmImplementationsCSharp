namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class PlusOne_66
{
    public static int[] PlusOne(int[] digits) //[9] - [0]
    {
        if (digits[^1] < 9)
        {
            digits[^1]++;
            return digits;
        }
        
        var i = digits.Length - 1; //0 - -1

        while (i >= 0 && digits[i] == 9)
        {
            digits[i] = 0;
            i--;
        }

        if (i == -1)
        {
            var extendedDigits = new int[digits.Length + 1];

            extendedDigits[0] = 1;
            
            Array.Copy(digits, 0, extendedDigits, 1, digits.Length);
            
            return extendedDigits;
        }
        
        digits[i]++;

        return digits;
    }
}