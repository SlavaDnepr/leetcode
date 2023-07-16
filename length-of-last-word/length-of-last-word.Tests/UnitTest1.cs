namespace length_of_last_word.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Hello World", 5)]
        [TestCase("   fly me   to   the moon  ", 4)]
        [TestCase("luffy is still joyboy", 6)]
        [TestCase("", 0)]
        [TestCase("          ", 0)]
        [TestCase("     a     ", 1)]
        public void Test1(string s, int expectedLength)
        {
            var solution = new Solution();
            var length = solution.LengthOfLastWord(s);

            Assert.That(length, Is.EqualTo(expectedLength));
        }
    }
}