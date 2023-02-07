var s = new Solution();
//Console.WriteLine(s.IntToRoman(2));
//Console.WriteLine(s.IntToRoman(12));
//Console.WriteLine(s.IntToRoman(27));
//Console.WriteLine(s.IntToRoman(9));
//Console.WriteLine(s.IntToRoman(24));
//Console.WriteLine(s.IntToRoman(30));
//Console.WriteLine(s.IntToRoman(1000));
//Console.WriteLine(s.IntToRoman(58));
//Console.WriteLine(s.IntToRoman(1900)); //MCM
//Console.WriteLine(s.IntToRoman(1994)); //MCMXCIV
//Console.WriteLine(s.IntToRoman(19));
//Console.WriteLine(s.IntToRoman(99));
Console.WriteLine(s.IntToRoman(900));

public class Solution
{
    public string IntToRoman(int num)
    {
        var res = string.Empty;
        var d = new Dictionary<int, char>
        {
            { 1000, 'M' },
            { 500, 'D' },
            { 100, 'C' },
            { 50, 'L' },
            { 10, 'X' },
        };

        var arr = new [] { 1000, 100, 100, 10, 10, 10 };

        for (int i = 0; i < d.Count; i++)
        {
            var key = d.ElementAt(i).Key;
            var value = d.ElementAt(i).Value;
            var s1 = num / key;
            if (s1 != 0)
            {
                for (int j = 0; j < s1; j++)
                {
                    res += value;
                }
            }
            num %= key;

            if ((num + key / Resolve3(key)) / key == 1)
            {
                res += Resolve2(key);
                num %= arr[i + 1];
            }

            if (num < 10)
                break;
        }
        
        res += Resolve(num);

        return res;
    }

    private static int Resolve3(int key)
    {
        return key switch
        {
            1000 => 10,
            500 => 5,
            100 => 10,
            50 => 5,
            _ => 1,
        };
    }

    private static string? Resolve2(int key)
    {
        return key switch
        {
            1000 => "CM",
            500 => "CD",
            100 => "XC",
            50 => "XL",
            _ => null
        };
    }

    private static string? Resolve(int c)
    {
        return c switch
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            _ => null
        };
    }
}