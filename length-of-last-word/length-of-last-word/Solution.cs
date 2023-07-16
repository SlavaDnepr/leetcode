namespace length_of_last_word;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        const char space = ' ';
        var lengthOfLastWord = 0;
        var lengthOfPrevWord = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == space)
            {
                if (lengthOfLastWord > 0)
                {
                    lengthOfPrevWord = lengthOfLastWord;
                    lengthOfLastWord = 0;
                }

                continue;
            }

            lengthOfLastWord++;
        }

        return lengthOfLastWord > 0 ? lengthOfLastWord : lengthOfPrevWord;
    }
}