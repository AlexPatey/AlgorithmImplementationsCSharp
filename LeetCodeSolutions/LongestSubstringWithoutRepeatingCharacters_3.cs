namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class LongestSubstringWithoutRepeatingCharacters_3
{
    public static int LengthOfLongestSubstring(string s)
    {
        var charSet = new HashSet<char>();
        var left = 0;
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            while (charSet.Contains(s[i]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            
            charSet.Add(s[i]);
            result = result > i - left + 1 ? result : i - left + 1;
        }

        return result;
    }
}