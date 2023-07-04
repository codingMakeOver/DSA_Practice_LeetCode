public class LengthOfLastWord_58
{
    public static int LengthOfLastWord(string s)
    {
        return s.Trim().Split(' ').Last().Length;
    }
}