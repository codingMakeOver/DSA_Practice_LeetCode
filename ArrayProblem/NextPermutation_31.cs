/*
 * for getting the next permutation we need to follow the 3 steps
 * Determine the point from where you will get lowest element which needs to be swapped. start from the last element and find out in left direction <-
 * you need understand that the array should be in descending order. so the last element will be the lowest.
 * so now you need to travers form left to right and check where this order is breaking
 * Then mark the point where the order is breaking 
 * Then find the immediate grater number of that lowest element ( which is not in the order) to its right array ->
 * swap those two 
 * and then reverse the rest of the element of the right of the point before the point where the swaped pointer was
 */

namespace ArrayProblem;

public static class NextPermutation_31
{
    public static void NextPermutation(int[] nums)
    {
        // iterate from the last and try to find the infraction point
        int infpt = 0;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] > nums[i - 1])
            {
                infpt = i;
                break;
            }
        }
        // this means we have the highest permutation
        // so we can now only reverse or sort the array
        if (infpt == 0)
        {
            Array.Sort(nums);
        }

        else
        {
            // get the number what is not in order and need to be swapped
            int toSwap = nums[infpt - 1];

            // search the number with which we need to swap
            // search the immediate grated number against the toswap
            for (int j = nums.Length - 1; j >= infpt; j--)
            {
                if (nums[j] > toSwap)
                {
                    int temp = nums[j];
                    nums[j] = toSwap;
                    nums[infpt - 1] = temp;
                    break;
                }
            }

            // do reverser/sort rest of the array to the right of infraction point
            //Array.Reverse(nums, infpt + 1, nums.Length - infpt + 1);
            Array.Sort(nums,infpt,nums.Length - infpt);
        }

    }
}
