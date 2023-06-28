namespace ArrayProblem;

public class RotateArray_189
{
    public static void Rotate(int[] nums, int k)
    {
        //int[] output = new int[nums.Length];
        //int j = 0;
        //// adding array element from the last to start
        //for (int i = nums.Length - k; i < nums.Length; i++)
        //{
        //    output[j++] = nums[i];
        //}
        //// add remaining array element to right of the array
        //for (int i = 0; i < nums.Length - k; i++)
        //{
        //    output[i + k] = nums[i];
        //}
        //nums = output;

        //foreach (var item in nums)
        //{
        //    Console.Write(item + ", ");
        //}
        // we will get the modulars of k because this will be equivalent of that many rotation
        // if k is 10 then there will be 3 rotation (10% length of the array)
        k = k% nums.Length;
        if (nums.Length <= 1 || k == 0) return;
        // [1,2,3,4,5,6,7]
        // first will reverse the entire array [7,6,5,4,3,2,1]
        Array.Reverse(nums,0, nums.Length);

        // next will reverse n array k element i.e is 0 to k-1
        // beacuse we have first reverse the array so that array become
        // here k element is 7,6,5 => 5,6,7,4,3,2,1
        Array.Reverse(nums, 0, k);
        // lastly we will reverse the reaming element i.e, 1,2,3,4
        Array.Reverse(nums, k, nums.Length - k);

        GC.Collect();
    }

    public static void reverse(int[] nums, int start, int end)
    {
        for (int i = 0; i <= (end - start) / 2; i++)
        {
            int tmp = nums[i + start];
            nums[i + start] = nums[end - i];
            nums[end - i] = tmp;
        }
    }
}
