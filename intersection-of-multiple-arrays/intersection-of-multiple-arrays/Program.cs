var s = new Solution();

int[][] nums = { new [] { 3, 1, 2, 4, 5 }, new [] { 1, 2, 3, 4 }, new [] { 3, 4, 5, 6 } };
var result = s.Intersection(nums);
s.Print(result);
int[][] nums2 = { new [] { 1, 2, 3 }, new [] { 4, 5, 6 }};
result = s.Intersection(nums2);
s.Print(result);
int[][] nums3 = { new[] { 3, 1, 2, 4, 5 }, new[] { 1, 2, 4 }, new[] { 3, 4, 3, 6 } };
result = s.Intersection(nums3);
s.Print(result);

public class Solution
{
    public IList<int> Intersection(int[][] nums)
    {
        var dict = new Dictionary<int, int>();
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                if (set.Add(nums[i][j]))
                {
                    if (dict.ContainsKey(nums[i][j]))
                        dict[nums[i][j]]++;
                    else
                        dict.Add(nums[i][j], 1);
                }
            }
            set.Clear();
        }

        var res = new List<int>();
        foreach (var (key, value) in dict)
            if (value == nums.Length)
                res.Add(key);

        res.Sort();

        return res;
    }

    public void Print(IList<int> result)
    {
        foreach (var i in result)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}