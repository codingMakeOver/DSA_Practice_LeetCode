namespace ArrayProblem;

public class JumpGame_55
{
    public static bool CanJump(int[] nums)
    {
        if(nums.Length == 1) return true;
        // we will adding a variable for tracking the last position 
        int lastPosition = nums.Length - 1;

        // traverse from the last and check if we can able to reach to the start index
        // we only check last and the last-1 position
        // we will check if we can move to last from last-1 
        // if so then we will change the last position and again do the same for the previous element
        // like if you have an array 2,3,1,1,4 in the respective index 0,1,2,3,4
        // will check if we can react from last - 1 index(3) to last index(4) then 3, 4 , yes we can react to  4 from 3
        // then will update the lastpostion = 3(index)
        // again check if we can move from index 2 to 3 i.e 1,1 -- yes
        // if there will be any value which is not allowing us to move(like - negative or zero) to the next element then will return false as we can go farther
        // if our lastposition reached to the first position then we can say we can do the jump
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            // check if we can move to last index
            if (i + nums[i] >= lastPosition) lastPosition = i;
        }
        return lastPosition == 0;
    }
}
