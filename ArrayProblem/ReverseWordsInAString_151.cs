using System.Text;

public class ReverseWordsInAString_151
{
    public static string ReverseWords(string s)
    {
        // split the array
        var strs = s.Split(' ');
        // using string builder for mutable string
        StringBuilder result = new StringBuilder();

        // start tracking the loop from the end of the string
        for (int i = strs.Length - 1; i >= 0; i--)
        {
            // if not a space then will add the word to the string builder
            if (!string.IsNullOrWhiteSpace(strs[i]))
            {
                string temp = strs[i].Trim();

                result.Append(temp + " ");
            }
        }

        // trim the whole string to remove the leading or trailing space
        return result.ToString().Trim();

        // solution #2
        // split, then reverse then join
        return string.Join(' ', s.Split(' ').Reverse().Where(e => e.Length > 0));
    }
}