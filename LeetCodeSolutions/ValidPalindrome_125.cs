namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class ValidPalindrome_125
{
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        
        var i = 0;
        var j = s.Length - 1;
        var validPalindrome = true;
        
        while (i <= j)
        {
            while (i < s.Length && !char.IsLetterOrDigit(s[i]))
            {
                i++;
            }

            while (j > 0 && !char.IsLetterOrDigit(s[j]))
            {
                j--;
            }

            if (i <= j && !s[i].ToString().Equals(s[j].ToString(), StringComparison.CurrentCultureIgnoreCase))
            {
                validPalindrome = false;
                break;
            }

            i++;
            j--;
        }
        
        return validPalindrome;
    }
}