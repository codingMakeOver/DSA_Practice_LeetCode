/*
 * Input: nums = [-4,-1,0,3,10]
    Output: [0,1,9,16,100]
    Explanation: After squaring, the array becomes [16,1,0,9,100].
    After sorting, it becomes [0,1,9,16,100].
*/


namespace ArrayProblem;

public class SortedSquares_977
{
    public static int[] SortedSquares(int[] nums)
    {
        if(nums.Length <= 0) return new int[0];
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * nums[i];
        }

        Array.Sort(nums);
        return nums;
    }
}
