namespace ArrayProblem;

public class JumpGameII_45
{
    public static int MinimumJump(int[] nums )
    {
        int minimumJumpCounter = 0, count= 0;
        if (nums[0] == 0) return 0;
        if (nums.Length == 1 && nums[0] != 0) return 1;

        // create new array which will have the maximum jump 
        // so basically we find the maximum jump can be taken from each index
        // index + value in that index 
        // then will check if anything is larger then that value is situated at the left side 
        // then replace that larger value 
        // ex: 2,3,1,1,4 index -- 0,1,2,3,4
        // like from the first index you can go max 2 steps so new array will be [(index+ value ), _ , _, _ , _] =>  [2, _ , _, _ , _]
        // next [2, (index+ value ), _ , _, _ ] => [2, (3+1),  _ , _, _ ] // and when adding the value in the new array we need to check if any larger value is in the previous array
        // next [2, 4, (index+ value ) , _, _ ] => [2, 4, (1+2) , _, _ ] // Now here you can see 1+2 = 3 is smaller then its previous value so the we will be adding 4

        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i] + i, nums[i - 1]);
        }

        while (count < nums.Length - 1)
        {
            minimumJumpCounter++;
            count = nums[count];
        }

        return minimumJumpCounter;
    }
}
