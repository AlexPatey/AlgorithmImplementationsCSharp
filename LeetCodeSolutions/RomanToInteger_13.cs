namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class RomanToInteger_13
{
    public static int RomanToInt(string s)
    {
        var roman = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]])
            {
                result -= roman[s[i]];
            }
            else
            {
                result += roman[s[i]];
            }
        }

        return result;

        //Alternative:
        
        // for (var i = 0; i < s.Length; i++)
        // {
        //     switch (s[i])
        //     {
        //         case 'I':
        //             if (i + 1 < s.Length)
        //             {
        //                 switch (s[i + 1])
        //                 {
        //                     case 'V':
        //                         result += 4;
        //                         i++;
        //                         break;
        //                     case 'X':
        //                         result += 9;
        //                         i++;
        //                         break;
        //                     default:
        //                         result += 1;
        //                         break;
        //                 }
        //             }
        //             else
        //             {
        //                 result += 1;
        //             }
        //             break;
        //         case 'V':
        //             result += 5;
        //             break;
        //         case 'X':
        //             if (i + 1 < s.Length)
        //             {
        //                 switch (s[i + 1])
        //                 {
        //                     case 'L':
        //                         result += 40;
        //                         i++;
        //                         break;
        //                     case 'C':
        //                         result += 90;
        //                         i++;
        //                         break;
        //                     default:
        //                         result += 10;
        //                         break;
        //                 }
        //             }
        //             else
        //             {
        //                 result += 10;
        //             }
        //             break;
        //         case 'L':
        //             result += 50;
        //             break;
        //         case 'C':
        //             if (i + 1 < s.Length)
        //             {
        //                 switch (s[i + 1])
        //                 {
        //                     case 'D':
        //                         result += 400;
        //                         i++;
        //                         break;
        //                     case 'M':
        //                         result += 900;
        //                         i++;
        //                         break;
        //                     default:
        //                         result += 100;
        //                         break;
        //                 }
        //             }
        //             else
        //             {
        //                 result += 100;
        //             }
        //             break;
        //         case 'D':
        //             result += 500;
        //             break;
        //         case 'M':
        //             result += 1000;
        //             break;
        //     }
        //
        // }
        // return result;
    }
}