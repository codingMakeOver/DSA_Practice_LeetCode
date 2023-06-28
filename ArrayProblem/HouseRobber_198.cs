namespace ArrayProblem;

public class HouseRobber_198
{
    // this problem is related to memorization
    // in the problem the robber can not rob adjust houses means immediate left or right of the element
    // in this problem we will be storing the max loot in a array and start comparing with that
    // like if we have a array 2,7,3,1,4,2,1,8
    // so initially in the array[0] we will store 2 and array[1] Max(nums[0], nums[1])
    // as in the initial set up there will not value to compare with , so wil choose nums[0]
    // now considering the second will compare with the first value
    // so our new array will be 2,7
    // now will be starting a loop from the i=2 to check the max element based on each index
    // now in the nums position 2 the value is 3
    // now we have two condition either you will loot the house or you will skip
    // if you will loot the house
    // that means you will consider the previous house [which is immediate left to it's adjustment value] => so 3's adjust value is 7 [from nums array] so we will pick the value from newarrya[i-2] = 2 as this is the max loot in that index. so looted value will be 2 + current loot i.e 3 =  5
    // now if you skip the house that means you have looted the adjacent house , in this case the max looted value is newArray[i-1] = 7
    // now we will be checking the max value and store in newarray[i] position => MAX(5,7) =7
    public static int Rob(int[] nums)
    {
        // if we only have tow element then we can not
        if(nums.Length < 3) return nums.Max();

        //lets create a array which will store the maximum looted value bases on the each index
        int[] maximumRobbed = new int[nums.Length];
        maximumRobbed[0] = nums[0];
        maximumRobbed[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            // if we chose to loot
            int ifLooted = maximumRobbed[i - 2] + nums[i];
            // if not chose to loot
            int ifNotLooted = maximumRobbed[i - 1];
            // taking the maximum and store in the maximumRobbed array

            maximumRobbed[i] = Math.Max(ifLooted, ifNotLooted);

        }

        return maximumRobbed[nums.Length - 1];
    }
}
