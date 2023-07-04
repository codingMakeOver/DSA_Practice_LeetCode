public class SearchInRotatedSortedArray_33
{
    public static int Search(int[] nums, int target)
    {
        // as this is in sorted format so we can try with binary search
        // for rotating array the sorted value is basically move to a different position after each rotation
        // [4,5,6,7,0,1,2] means this array was [0,1,2,4,5,6,7] in the beginning but with 4 rotation the array has changed
        // we need to find the mid and check if the left is sorted if left is not sorted then the right side must be in sorted order as this was a sorted array before making any rotation 
        // so from mid we will check which part is sorted and will try ot find out element in that part only
        // will ignore the rest of the part

        // initialize nums first and last position as will be calculation the mid
        int low = 0, high = nums.Length - 1;

        if(nums.Length == 2)
        {
            return nums[0] == target ? 0 : nums[1] == target ? 1 : -1;
        }

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (nums[mid] == target) return mid;

            /// this mean left side is sorted
            if (nums[mid] >= nums[low])
            {
                if (target >= nums[low] && target < nums[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            /// this mean right side is sorted
            else
            {
                if (target > nums[mid] && target <= nums[high])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
        }

        return -1;


        //int low = 0, high = nums.Length - 1;

        //while (low <= high)
        //{
        //    int mid = (low + high) / 2;

        //    if (nums[mid] == target)
        //    {
        //        return mid;
        //    }
        //    /// this mean left side is sorted
        //    else if (nums[low] <= nums[mid])
        //    {
        //        if (target > nums[mid] || target < nums[low])
        //            low = mid + 1;
        //        else high = mid - 1;
        //    }

        //    else
        //    {
        //        if (target < nums[mid] || target > nums[high])
        //            high = mid - 1;
        //        else low = mid + 1;
        //    }
        //}


        //return -1;
    }
}