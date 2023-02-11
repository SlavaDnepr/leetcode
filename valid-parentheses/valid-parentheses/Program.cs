var s = new Solution();

Console.WriteLine(s.IsValid("()"));
Console.WriteLine(s.IsValid("()[]{}"));
Console.WriteLine(s.IsValid("(]"));
Console.WriteLine(s.IsValid("("));
Console.WriteLine(s.IsValid("]"));

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (IsOpened(s[i]))
            {
                stack.Push(s[i]);
                continue;
            }

            if (IsClosed(s[i]))
            {
                var prev = stack.Count != 0 ? stack.Pop() : '0';
                if (IsValidPair(s[i], prev))
                    continue;

                return false;
            }
        }

        return stack.Count == 0;
    }

    private bool IsValidPair(char c, char prev)
    {
        switch (c)
        {
            case ')' when prev == '(':
            case ']' when prev == '[':
            case '}' when prev == '{':
                return true;
            default:
                return false;
        }
    }

    private static bool IsOpened(char c) => c is '(' or '[' or '{';

    private static bool IsClosed(char c) => c is ')' or ']' or '}';
}