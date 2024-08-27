namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class ValidParentheses_20
{
    public static bool IsValid(string s) //{[]}
    {
        if (s.Length % 2 != 0 || s.Length > 0 && (s[0] == ')'  || s[0] == ']' || s[0] == '}'))
        {
            return false;
        }
        
        var stack = new Stack<char>();
        
        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(c);
                    break;
                case ')' when stack.Count == 0 || stack.Peek() != '(':
                case ']' when stack.Count == 0 || stack.Peek() != '[':
                case '}' when stack.Count == 0 || stack.Peek() != '{':
                    return false;
                default:
                    _ = stack.Pop();
                    break;
            }
        }

        return stack.Count == 0;
    }
}