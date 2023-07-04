public class SearchnRotatedSortedArrayII_81
{
    public static bool Search(int[] nums, int target)
    {
        // first check if the array is in sorted order
        int i = 0;

        // here we are trying to find the point of rotation 
        // we will find the point of rotation from where the shorting is breaking
        // If target is found before finding point of rotation, return true.
        while (i < nums.Length - 1 && nums[i] <= nums[i + 1])
        {
            if (nums[i] == target) return true;
            i++;
        }

        // if array has only one length and that is equal to target
        if (i< nums.Length && nums[0] == target)
            return true;

        // here we low is set to i +1 
        // because from the above loop we have check is the shorted part is the target preset or not
        // as that is not present so we must discurd that part and start from next i.e i + 1
        // basically once the point of rotation is found(i) it just indicates that the remaining part of the array is properly sorted
        int low = i + 1;
        int high = nums.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (nums[mid] > target)
                high = mid - 1;
            else if (nums[mid] < target)
                low = mid + 1;
            else //if (nums[mid] == target)
                return true;
        }
        return false;

        // solution #2
        //int low = 0;
        //int high = nums.Length - 1;
        //while (low <= high)
        //{
        //    int mid = (low + high) / 2;
        //    if (nums[mid] == target)
        //        return true;

        //    if (nums[mid] == nums[low] && nums[mid] == nums[high])
        //    {
        //        low++;
        //        high--;
        //    }
        //    else if (nums[mid] <= nums[high])
        //    {
        //        //right half is sorted
        //        if (target > nums[mid] && target <= nums[high])
        //        {
        //            low = mid + 1;
        //        }
        //        else
        //        {
        //            high = mid - 1;
        //        }
        //    }
        //    else
        //    {
        //        //left half is sorted
        //        if (target >= nums[low] && target < nums[mid])
        //        {
        //            high = mid - 1;
        //        }
        //        else
        //        {
        //            low = mid + 1;
        //        }
        //    }
        //}
        //return false;
    }

}