namespace ArrayProblem;

public class RemoveDuplicatesFromSortedArrayII_80
{
    public static int RemoveDuplicates(int[] nums)
    {
        //in this problem we can consider maximum two duplicate element 
        // so the first index and second index either be equal or different 
        // so initially we will consider this two and start the comparing from next index(2)
        // As this is a sorted list so third element we need to compare 
        // means for example we have an array - 1,1,1,2,2,3
        // so will start from 2nd index - i.e - 1
        // this is clear that if first two element is same we can cosider but if the third element is same as the first this means we have a duplicate
        // like index 2 = 1 and index(0) = 1(nums[i-2]) so both are equal so will not take index 2 and will move forward

        int i = 0;
        foreach (var item in nums)
        {
            if(i < 2 || item != nums[i - 2])
            {
                nums[i++] = item;
            }
        }

        return i;
    }
}
