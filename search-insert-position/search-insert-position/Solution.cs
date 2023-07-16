namespace search_insert_position;

public static class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        if (nums is not { Length: not 0 }) return 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                return i;

            if (nums[i] > target) return i;
        }

        return nums.Length;
    }
}