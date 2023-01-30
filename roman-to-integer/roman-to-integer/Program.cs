var s = new Solution();

Console.WriteLine(s.RomanToInt("III"));
Console.WriteLine(s.RomanToInt("IV"));
Console.WriteLine(s.RomanToInt("XII"));
Console.WriteLine(s.RomanToInt("XXVII"));
Console.WriteLine(s.RomanToInt("LVIII"));
Console.WriteLine(s.RomanToInt("MCMXCIV"));


public class Solution
{
    public int RomanToInt(string s)
    {
        var sum = 0;
        var prev = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var current = ResolveSymbol(s[i]);
            sum += current;
            if (prev < current)
                sum -= prev*2;
            prev = current;
        }

        return sum;
    }

    private static int ResolveSymbol(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
        };
    }
}