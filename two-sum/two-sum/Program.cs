// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var s = new Solution();
var r = s.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine(r);


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (nums[i] + nums[j] == target)
                    return new[] { i, j };
            }
        }

        return null;
    }
}