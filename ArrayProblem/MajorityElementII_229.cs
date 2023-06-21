namespace ArrayProblem;

public class MajorityElementII_229
{
    public static IList<int> MajorityElement(int[] nums)
    {
        // thumb rule is there can not be more than 2 element 
        // because if you devide n by 3 this will occupied above 90% of the array by only two element
        // ex if n is 50 then 50/3 = 16 , so the element must be more then 16 ( which is the constaint of the question)
        // so if one element covers 17 another 17 so only 16 will be remain and we need an element which must be more than n/3 that is 16
        // we can use dictionary or hashmap to solve the issue but "Could you solve the problem in linear time and in O(1) space?"
        // we will be using  Moore's Vooting Algorithm
        // in this algoritham we basically need to create distinct pair , and which will be remain those element have the potential to be the majority element
        //[3,5,3,9,5,3] // if i find the distinct element pair(which must be of 3 *thumbrule ^)
        // [3,5,9] so now we can not make any distinct element
        // now remain item is [3,5,3] so the majority element will be from the reaming element

        // check if length is lass then 2 means 1 then we will return the nums 
        // as we must have atlest 2 element
        if (nums.Length < 2) return nums;

        // will add two variable for keeping the potential 2 elements and their occurrence 
        // countP1 is 1 as we start track with the first element 
        int potential1 = nums[0], potential2 = nums[0], countP1 = 1, countP2 = 0;

        // Here we will first check if the array element is equal to the potential1 or potential2
        // if it matches any of the variable value then will increase countP1 or countP2 
        // if not matched then we need to check if any of count is 0 , then will increase the count and update potential with that unmatched element
        // if non of the element is matched and we did not have any counter which have 0 then we will decrease both countP1 and countP2 by -1

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == potential1)
            {
                countP1++;
            }
            else if (nums[i] == potential2)
            {
                countP2++;
            }
            else
            {
                if(countP1 == 0)
                {
                    potential1 = nums[i];
                    countP1++;
                }
                else if(countP2 == 0)
                {
                    potential2 = nums[i];
                    countP2++;
                }
                else
                {
                    countP1--;
                    countP2--;
                }
            }
        }
        //reset the counter
        countP1 = 0; countP2 = 0;
        // now check the occurrence of the potential1 and potential2
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == potential1) countP1++;
            else if (nums[i] == potential2) { countP2++; }
        }

        // now check if the count is grater then n/3
        IList<int> list = new List<int>();
        if(countP1 > nums.Length / 3) list.Add(potential1);
        if(countP2 > nums.Length / 3) list.Add(potential2);
        
        return list;

        // solution 2 with hashmap
        //int LenLimit = nums.Length / 3;
        //var StatisticNums = new Dictionary<int, int>();
        //foreach (int i in nums)
        //{
        //    if (StatisticNums.ContainsKey(i))
        //    {
        //        StatisticNums[i]++;
        //    }
        //    else
        //    {
        //        StatisticNums.Add(i, 1);
        //    }
        //}
        //return StatisticNums.Where(x => x.Value > LenLimit).Select(x => x.Key).ToList();
    }
}
