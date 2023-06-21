namespace GreedyAlgorithm;

public static class MaximumProductOf3Numbers_628
{
    public static int MaximumProduct(int[] nums)
    {
        // sort the array
        Array.Sort(nums);
        int length = nums.Length - 1;
        // get multiplication of highest 3 elements
        int heighest3 = nums[length] * nums[length - 1] * nums[length - 2];
        // get multiplication of lowest 3 elements
        int lowest3 = nums[0] * nums[1] * nums[2];
        return Math.Max(heighest3, lowest3);
    }
}
