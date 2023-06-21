namespace ArrayProblem;

public static class FindDuplicateNumeber_287
{
    public static int FindDuplicate(int[] nums)
    {
        #region Solution1

        // initialize a list of the same size of nums and assign false
        bool[] seen = new bool[nums.Length];

        // iterate through the loop based on nums
        // check if the list[i]  is true then return
        // else continue and update the list
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen[nums[i]]) return nums[i];
            else seen[nums[i]] = true;
        }

        return -1;

        #endregion
    }
}
