// See https://aka.ms/new-console-template for more information
var s = new Solution();
var same = new[] { "flower", "flower", "flower", "flower" };
Console.WriteLine(s.LongestCommonPrefix(same));
var strsEmpty = new[] { "" };
Console.WriteLine(s.LongestCommonPrefix(strsEmpty));
var strs0 = new[] { "a" };
Console.WriteLine(s.LongestCommonPrefix(strs0));
var strs = new[] { "flower", "flow", "flight" };
Console.WriteLine(s.LongestCommonPrefix(strs));
var strs1 = new[] { "dog", "racecar", "car" };
Console.WriteLine(s.LongestCommonPrefix(strs1));

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = string.Empty;

        if (strs == null || strs[0].Length == 0)
            return prefix;

        for (int j = 1; j <= strs[0].Length; j++)
        {
            string candidate = strs[0][..j];

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].StartsWith(candidate))
                    continue;

                return prefix;
            }

            prefix = candidate;
        }

        return prefix;
    }
}