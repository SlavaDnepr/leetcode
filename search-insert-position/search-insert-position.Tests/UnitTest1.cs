namespace search_insert_position.Tests;

public class Tests
{
    [TestCase(new[] { 1, 3, 5, 6 }, 5, 2)]
    [TestCase(new[] { 1, 3, 5, 6 }, 2, 1)]
    [TestCase(new[] { 1, 3, 5, 6 }, 0, 0)]
    [TestCase(new[] { 1, 3, 5, 6 }, 7, 4)]
    [TestCase(new[] { 1 }, 0, 0)]
    [TestCase(new[] { 1 }, 1, 0)]
    [TestCase(new[] { 1 }, 2, 1)]
    [TestCase(null, 0, 0)]
    public void Test1(int[] nums, int target, int expectedIndex)
    {
        var index = Solution.SearchInsert(nums, target);

        Assert.That(index, Is.EqualTo(expectedIndex));
    }
}