
namespace ArrayProblem;
//https://leetcode.com/problems/sort-colors/solutions/1256365/c-easy-to-understand-full-explanation/
//https://www.youtube.com/watch?v=6sMssUHgaBs
public class SortColors_75
{
    public static void SortColors(int[] nums)
    {
        // in this problem we need to take 3 pointer start, mid and end
        //We'll use mid pointer to traverse and check the array elements i.e. while(mid <= high). Three cases are possible:
        //nums[mid] == 0 In this case swap(nums[low], nums[mid]) and increment both low and mid pointer i.e.low++ mid++
        //nums[mid] == 1 In this case mid++
        //nums[mid] == 2 In this case swap(nums[mid], nums[high]) and decrement high pointer i.e.high--

        int start = 0, mid = 0, end = nums.Length - 1;

        // we will check if element(nums[mid]) is 0
        // that means that needs to go on the left of the mid
        // but if the element is 1 then that is in corect position 

        // we will check the element using the mid , so mid element should be 1 , if that is correct place means num[mid] == 1 then we will just move the mid
        // similarly if the num[mid] == 0 means that is not its correct position , that needs to swap to left => swap(num[mid],num[start]) 
        // similarly if the num[mid] == 2 means that is not its correct position , that needs to swap to right => swap(num[mid],num[end]) 
        
        while (mid <= end)
        {
            if (nums[mid] == 0)
            {
                // swap mid with start
                Swap(nums, start, mid);
                // so now the 0 will be placed to its correct position 
                // so that the pointer can move forward
                mid++;
                start++;
            }
            else if (nums[mid] == 1)
            {
                // mid == 1 means we just need to move the mid as this is in the correct position
                mid++;
            }
            else
            {
                // swap with end
                Swap(nums, end, mid);
                end--;
            }
        }
        foreach (int i in nums)
        {
            Console.Write(i + " ");
        }
    }

    private static void Swap(int[] nums, int start, int mid)
    {
        int temp = nums[mid];
        nums[mid] = nums[start];
        nums[start] = temp;
    }
}
