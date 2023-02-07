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
        HashSet<char> chars = new();
        for (int i = 0; i < n; i++)
        {
            chars.Add(s[i]);
            for (int j = i + 1; j < n; j++)
            {
                if (!chars.Contains(s[j]))
                    chars.Add(s[j]);
                else
                    break;
            }

            if (max < chars.Count)
                max = chars.Count;


            chars.Clear();
        }

        return max;
    }
}
