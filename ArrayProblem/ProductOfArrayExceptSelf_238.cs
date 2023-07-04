namespace ArrayProblem;

public class ProductOfArrayExceptSelf_238
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        // main trick is we can not use division operator 
        // this is a prefix product problem
        // we will be taking creating two array one for storing product from left and another from right
        // [1,2,3,4] -> 
        // now if we start creating the multiplication from right => last element 4 does't have anything to its right
        // so the array will be [_,_,_,4] , then [_,_,3*4,4] => [_,2*3*4,3*4,4] => [1*2*3*4,2*3*4,3*4,4]
        // similarly we will crate a array from left => [1,1*2,1*2*3,1*2*3*4]
        // then we will use those two array to calculate the result
        // Now we start iterating the actual array [1,2,3,4]
        // i =0 nums[i] = 1, now will check the right and left product,in this case there have no element in the right of 1 so will check the right array for the product of  2*3*4 = 24
        // i=1 nums[i] =2, now 1 is left of 2 and 3,4 is right of 2 so from left array will take la[i-1] and from right array[i+1] 
        int n = nums.Length;
        int[] ans = new int[n];
        
        int[] leftPrefixProduct = new int[n];
        int[] rightPrefixProduct = new int[n];
        leftPrefixProduct[0] = nums[0];
        rightPrefixProduct[n-1] = nums[n - 1];
        for (int i = 1, j = n -2; i < n && j>=0; i++, j--)
        {
            leftPrefixProduct[i] = leftPrefixProduct[i-1] * nums[i];
            rightPrefixProduct[j] = rightPrefixProduct[j+1] * nums[j];
        }

        ans[0] = rightPrefixProduct[1];
        ans[n - 1] = leftPrefixProduct[n-2];
        for (int i = 1; i < n-1; i++)
        {
            ans[i] = leftPrefixProduct[i-1] * rightPrefixProduct[i+1];
        }

        return ans;
    }
}
