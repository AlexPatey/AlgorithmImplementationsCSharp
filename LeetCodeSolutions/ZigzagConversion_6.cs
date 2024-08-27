namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class ZigzagConversion_6
{
    public static string Convert(string s, int numRows) //"PAYPALISHIRING"; 4 - 
    {
        var result = string.Empty; //"" - "P" - "PA" - "PAH" - "PAHN" - 
        var index = 0; // 0 - 4 - 8 - 12 - 16 - 1
        var i = 0; // 0 - 

        while (result.Length != s.Length) //14
        {
            if (index < s.Length)
            {
                result += s[index];
                index += numRows;
            }
            else
            {
                i++;
                index = 0 + i;
            }
        }

        return result;
    }
}