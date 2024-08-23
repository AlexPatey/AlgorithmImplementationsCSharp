namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class PalindromeNumber_9
{
    public static bool IsPalindrome(int x)
    {
        var original = x.ToString();
        var reversed = string.Empty;

        for (var i = original.Length - 1; i >= 0 ; i--)
        {
            reversed += original[i];
        }
        
        return reversed == original;
    }
}