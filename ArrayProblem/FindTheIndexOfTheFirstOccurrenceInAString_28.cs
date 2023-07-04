public class FindTheIndexOfTheFirstOccurrenceInAString_28
{
    public static int StrStr(string haystack, string needle)
    {
        // in this problem we need to first check if the first character of needle is present 
        // if we found the first character then we will check the entire needle with haystack
        // another important note: needle always be less then the haystack. means if needle length is 5 and haystack length is 10 then,
        // under maximum of haystack will be 10-5 where we can get the needle word
        // like if haystack = "aaabkbhhh" and needle = "bkb" max index = haystack.Length - 1 - (needle.Length - ) = 6
        // now will iterate the loop and search for the first occurrence of needle
        // if we found that then we will search the rest
        // return -1 if needle is grater then the haystack
        if (needle.Length > haystack.Length) return -1;
        // iterate and check the occurrence of the index
        for (int i = 0; i < haystack.Length; i++)
        {
            // if we found the occurrence
            if (haystack[i] == needle[0])
            {
                // now we will check the substring of needle is equal to needle
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
        }
        return -1;

        // solution #2
        if (needle.Length > haystack.Length) return -1;
        return haystack.IndexOf(needle);
    }
}