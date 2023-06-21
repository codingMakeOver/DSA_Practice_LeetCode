namespace ArrayProblem;

public class SortArrayByParity_905
{
    //refer : Sort0And1 comments
    public static int[] SortArrayByParity(int[] nums)
    {
        int j = 0, i = 0;
        while (i < nums.Length) 
        {
            if (nums[i] % 2 != 0)
            {
                i++;
            }
            else
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++; j++;
            }
        }
        return nums;
    }
}
