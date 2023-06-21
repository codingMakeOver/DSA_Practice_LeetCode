namespace ArrayProblem;

// in this question we need to find the avg of element. k element to the left + the element + k element to the right
// so to getting the average we need to add all the 7(3left + the element + 3right) element and divided by 2*k+1
// [7,4,3,9,1,8,5,2,6], k = 3
// 7 + 4 + 3 + /9\ + 1 + 8 + 5 = 37. /  2*3 + 1 = 5
public class KRadiusSubarrayAverages_2090
{
    public static int[] GetAverages(int[] nums, int k)
    {
        // in this problem we need to use the prefix sum
        // first we need to initialize a array with -1 or you can start initialize -1 when the element did not have k element on the right and k element in the right
        // for creating the prefix array we need to start adding element and store in a new array
        // like if you have an array : 7, 4, 3, 9, 1, 8, 5, 2, 6 
        // prefix array will be 0+7, 7+4, 7+4+3 ans so on..
        // after creating the prefix array we need to run a loop which must start from k 
        // because there should be K elements in the left of the array item. for the first array element [0] there will not have any element so this will not fullfil the requirement , i.e, kth item should be in the left and right
        // so will start from kth element and will rull till k+l < length as if we consider the last element of the array 
        // that element also did not have any array value to its right so this will not fulfil the requirement 

        // create an initialize a array with -1
        int[] result = Enumerable.Repeat(-1, nums.Length).ToArray();
        if (nums.Length < (2 * k + 1)) return result;
        int len = nums.Length;
        long[] prefix = new long[len];
        prefix[0] = nums[0];
        for (int i = 1; i < len; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }
        for (int i = k; i+k < len; i++)
        {
            // Here will try to find the sum of the element (3 from left + element + 3 from right)
            // from the prefix we will found the sum in each index
            // so for getting the sum we will take the prefix [i+k] position and then minus the i-k and then add num[i-k]
            // basically we will subtract the element which will not fall in the window (3 from left + element + 3 from right)
            // then we need to add the actual value in the index position 
            // ex - 7, 4, 3, 9, 1, 8, 5, 2, 6 => prefix [7,11,14,23,24,32,37,39,45]
            // for i =3 as the loop will be starting from k
            // (p[3 +3] - p[3 - 3]) + nums[3-3] => (37 - 7) + 7 = 37 / 7 = 5
            // i = 4
            // (p[4 +3] - p[4 - 3]) + nums[4-3] => (39 - 11) + 4 = 32 / 7 = 4
            result[i] = (int)((prefix[i + k] - prefix[i - k] + nums[i - k]) / (2 * k + 1));

        }
        return result;

    }
}
