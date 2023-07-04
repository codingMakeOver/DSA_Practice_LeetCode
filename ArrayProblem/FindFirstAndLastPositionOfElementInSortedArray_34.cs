public class FindFirstAndLastPositionOfElementInSortedArray_34
{
    public static int[] SearchRange(int[] nums, int target)
    {
        // will calculate the mid 
        // then check in whihc part the target is and then do i+1 to get the next target 
        // As both are in sorted format
        if (nums.Length <= 1)
        {
            if (nums.Length == 0 || nums == null) return new int[] { -1, -1 };
            return nums[0] == target ? new int[] { 0, 0 } : new int[] { -1, -1 };
        }

        int low = 0, high = nums.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if ((nums[mid] == target))
            {
                int start = mid;
                int end = mid;

                while ((start - 1 > -1) && (nums[start - 1] == target))
                {
                    start -= 1;
                }

                while ((end + 1 < nums.Length) && (nums[end + 1] == target))
                {
                    end += 1;
                }

                return new int[] { start, end };
            }

            else if (target <= nums[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return new int[] { -1, -1 };
    }
}
