namespace plus_one;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var newDigits = new List<int>();
        var next = 1;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var val = digits[i] + next;
            if (val == 10)
            {
                newDigits.Add(0);
                next = 1;

                if (i == 0)
                    newDigits.Add(1);
            }
            else
            {
                newDigits.Add(val);
                next = 0;
            }
        }

        newDigits.Reverse();

        return newDigits.ToArray();
    }
}