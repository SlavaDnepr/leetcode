var s = new Solution();
var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
s.Print(nums);
Console.WriteLine(s.RemoveDuplicates(nums));
s.Print(nums);

var nums2 = new int[] { 1, 1, 2 };
s.Print(nums2);
Console.WriteLine(s.RemoveDuplicates(nums2));
s.Print(nums2);

var nums3 = new int[] { 1, 2 };
s.Print(nums3);
Console.WriteLine(s.RemoveDuplicates(nums3));
s.Print(nums3);

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        var current = nums[0];
        var length = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == current || nums[i] < current)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > current)
                    {
                        nums[i] = nums[j];
                        current = nums[i];
                        length++;
                        break;

                    }
                }
            }
            else
            {
                current = nums[i];
                length++;
            }
        }

        return length;
    }

    public void Print(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
            Console.Write(nums[i] + " ");

        Console.WriteLine();
    }
}