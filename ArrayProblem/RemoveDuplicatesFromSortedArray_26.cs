namespace ArrayProblem;

public class RemoveDuplicatesFromSortedArray_26
{
    public static int RemoveDuplicates(int[] nums)
    {
        int arrayIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[arrayIndex] = nums[i];
                arrayIndex++;
            }
        }
        return arrayIndex;
    }
}
