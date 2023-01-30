using System.Collections.Generic;

var s = new Solution();

var str6 = "dvdf";
Console.WriteLine(s.LengthOfLongestSubstring(str6));

var str5 = "au";
Console.WriteLine(s.LengthOfLongestSubstring(str5));

var str0 = "a";
Console.WriteLine(s.LengthOfLongestSubstring(str0));

var str1 = "abcabcbb";
Console.WriteLine(s.LengthOfLongestSubstring(str1));

var str2 = "bbbbb";
Console.WriteLine(s.LengthOfLongestSubstring(str2));

var str3 = "pwwkew";
Console.WriteLine(s.LengthOfLongestSubstring(str3));

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s == null || s.Length == 0) return 0;

        int max = 0;
        var n = s.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var current = j - i + 1;
                if (Check(s, i, j))
                    if (max < current)
                        max = current;
            }
        }

        return max;
    }

    private bool Check(string s, int start, int end)
    {
        HashSet<char> chars = new HashSet<char>();

        for (int i = start; i <= end; i++)
        {
            if (chars.Contains(s[i]))
                return false;

            chars.Add(s[i]);
        }

        return true;
    }
}
