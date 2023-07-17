namespace plus_one.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [TestCase(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [TestCase(new[] { 9 }, new[] { 1, 0 })]
    [TestCase(new[] { 1, 9 }, new[] { 2, 0 })]
    [TestCase(new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
    public void Test1(int[] digits, int[] expectedDigits)
    {
        var solution = new Solution();
        var actualDigits = solution.PlusOne(digits);

        Assert.That(actualDigits, Is.EquivalentTo(expectedDigits));
    }
}