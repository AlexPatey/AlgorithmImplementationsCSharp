namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class LengthOfLastWord_58
{
    public static int LengthOfLastWord(string s)
    {
        var length = 0;
        var endOfInitialWhiteSpace = false;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                endOfInitialWhiteSpace = true;
                length++;
            }
            else if (endOfInitialWhiteSpace && s[i] == ' ')
            {
                return length;
            }
        }

        return length;
    }
}