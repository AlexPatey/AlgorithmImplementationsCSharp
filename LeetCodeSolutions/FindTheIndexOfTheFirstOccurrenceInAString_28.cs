namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class FindTheIndexOfTheFirstOccurrenceInAString_28
{
    public static int StrStr(string haystack, string needle) // "sadbutsad"; "sad" - 
    {
        if (needle == string.Empty)
        {
            return 0;
        }

        for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            for (var j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    break;
                }

                if (needle.Length - 1 == j)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}