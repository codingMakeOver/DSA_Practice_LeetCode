namespace ArrayProblem;

public class _3SumClosest_16
{
    // first we will shot the array because we need to find the closest of sum so sorting element can have bigger chance to give the sum result in slowly incremental order
    // this we can do be fixing the first element , then second and so on 
    // and calculating sum with start + end pointer and + the fixed element
    // if the sum is grater the target sum then will decrement the end pointer and if lower then increase the start pointer
    // in a variable we will keep the difference so that we can able to know is the sum is more closer then the previous one if so then we will update the diff 



    public static int ThreeSumClosest(int[] nums, int target)
    {

       // sort the array
       Array.Sort(nums);
        int diffrence = int.MaxValue, ans = 0;
        // fixing one element at a time and calculate the sum with other values
        for (int i = 0; i < nums.Length; i++)
        {
            int fixedElement = nums[i];
            // take start point immediate to the fixedElement
            int start = i + 1;
            int end = nums.Length - 1;
            
            // we will be terminating the inner loop when start or end pointing to same index
            while(start < end)
            {
                // if the sum itself is target then return target
                if (nums[start] + nums[end] + fixedElement == target) return target;
                else if ((Math.Abs((nums[start] + nums[end] + fixedElement) - target)) < diffrence)
                {
                    diffrence = Math.Abs((nums[start] + nums[end] + fixedElement) - target);
                    ans = nums[start] + nums[end] + fixedElement;
                }

                if(nums[start] + nums[end] + fixedElement < target) start++;
                else end--;
            }
        }
        GC.Collect();
        return ans;
    }
}
