namespace ArrayProblem;

public class IsLongPressedName_925
{
    public static bool IsLongPressedName(string name, string typed)
    {
        // check if typed character less then the name 
        // then return false as this will not be possible for creating a name from the typed character 
        if(name.Length > typed.Length) return false;

        // adding two variable to track the current index of name and typed string
        int i = 0, j = 0;

        // iterate throw the two string and check if creating the name is possible
        // loop will be continue until i and j exhausts the length of name and typed string
        while(i < name.Length && j < typed.Length)
        {
            // check if both name and typed string are same
            // then move the pointer forward
            if (name[i] == typed[j])
            {
                i++;
                j++;
            }
            // now if the two charcter if not same the we will check the typed's next character with the previous character of name
            // as typed string can have multiple same wrongly typed character but name will not have that
            // like name = abc typed = aabc
            // so we will be comparing first name[0] = typed[0] if not then name[0] == typed[1]
            else if(i > 0 && name[i - 1] == typed[j])
            {
                j++;
            }
            // if nothing matched then return false
            else
            {
                return false;
            }
        }

        // there can be case where i is exhausts but j still less then the typed length
        // like name = abbcc and typed abbccc
        // so we have extra c at in the typed string which have wrongly added
        // so when we will be comparing and forwarding the i and j , i will be react to the end but j will still have c to check
        while(j < typed.Length)
        {
            if (name[i-1] != typed[j]) return false;
            j++;
        }

        // there might be another case when i will have some value but j is exhausts
        // like name = abd and typed aaabbc
        // In anyhow your name stirng should be traversed to the end 
        // only then we can know the actual typed name
        return i < name.Length ? false : true;
    }
}
