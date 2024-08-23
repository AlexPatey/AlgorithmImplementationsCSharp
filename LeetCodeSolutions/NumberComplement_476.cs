namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class NumberComplement_476
{
    public static int FindComplement(int num)
    {
        int quotient;
        var result = 0;
        var i = 0;
        
        do
        {
            quotient = num / 2;
            if (num % 2 == 0)
            {
                result += (int)Math.Pow(2, i); 
            }
            num /= 2;
            i++;

        } while (quotient is not 0);

        return result;
    }
}