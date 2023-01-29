var s = new Solution();
Console.WriteLine(s.IsPalindrome(125621));
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 ) return false;

        var digits = x.ToString().Select(t => int.Parse(t.ToString())).ToArray();
        var isPalindrome = true;
        var len = digits.Length / 2;
        for (var i = 0; i < len; i++)
        {
            if (digits[i] != digits[digits.Length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}