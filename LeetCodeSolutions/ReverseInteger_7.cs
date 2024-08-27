namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class ReverseInteger_7
{
    public static int Reverse(int x)
    {
        var xString = x.ToString();
        var reversedXString = string.Empty;
        bool isParsed;
        int reversedInt;
        if (xString[0] is '-')
        {
            for (var i = xString.Length - 1; i >= 1; i--)
            {
                reversedXString += xString[i];
            }
         
            reversedXString = "-" + reversedXString;

            isParsed = int.TryParse(reversedXString, out reversedInt);

            return isParsed ? reversedInt : 0;
        }

        for (var i = xString.Length - 1; i >= 0; i--)
        {
            reversedXString += xString[i];
        }
            
        isParsed = int.TryParse(reversedXString, out reversedInt);

        return isParsed ? reversedInt : 0;
    }
}