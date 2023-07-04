public class BuddyStrings_859
{
    public static bool BuddyStrings(string s, string goal)
    {
        // to solve this question , thumb rule is only two character in goal string will be in two different index as compare to the s string.
        // both will be consider as equal only after swapping the s will be same as goal
        // first we will check the length
        // then will check the frequency of the character , if the result set lenght is less than s then will return true else false 
        // means if you have stirng aaa so in hasset unique string is only one a which is less than s
        // then will check the difference is only 2 and check the charcters on that indexes


        // if length is not equal hen return false
        if (s.Length != goal.Length) return false;

        // if both have equal length 
        if(s == goal)
        {
            // check the frequency of each character 
            HashSet<char> unique_char_frequency = new HashSet<char>();
            foreach (var c in s)
            {
                unique_char_frequency.Add(c);
            }
            // if s = "a" and goal = "a"
            // this means both are equal but in hasset count will 1 (a) and s.length will be 1 so this swap will not be possible.
            // but if s ="aaa" and goal = "aaa" both will be equlal but hashset will be 1 as it only store one a as a unique key so lenght of hasset will be less then s 
            // based on that condition we are returning true/false
            return unique_char_frequency.Count() < s.Length ? true : false;
        }

        List<int> diffCharcter = new();
        // now we will be checking if the diffence charactr and store them in the list
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != goal[i])
            {
                diffCharcter.Add(i);
            }
        }

        // check the we only have 2 difference and the alternet position both characters are equal
        if(diffCharcter.Count == 2 
            && s[diffCharcter[0]] == goal[diffCharcter[1]]
            && s[diffCharcter[1]] == goal[diffCharcter[0]])
        {
            return true;
        }
        return false;

    }
}