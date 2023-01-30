var s = new Solution();
Console.WriteLine(s.IsPalindrome(125621));
Console.WriteLine(s.IsPalindrome(12521));
Console.WriteLine(s.IsPalindrome(1221));
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 ) return false;

        var digits = x.ToString();
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