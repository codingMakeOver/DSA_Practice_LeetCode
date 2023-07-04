#region FindDuplicateNumeber_287

using ArrayProblem;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Text;

//int[] nums = new int[] { 3, 1, 3, 4, 2 };
//var result = FindDuplicateNumeber_287.FindDuplicate(nums);
//Console.WriteLine(result);
//

#endregion

#region NextPermutation_31

//int[] nums = new int[] { 1,3,5,4,2 };
//NextPermutation_31.NextPermutation(nums);


#endregion

#region IsLongPressedName_925

//Console.WriteLine(IsLongPressedName_925.IsLongPressedName("saeed", "ssaaedd"));

#endregion

#region SortedSquares_977

//Console.WriteLine(SortedSquares_977.SortedSquares(new int[] { -4, -1, 0, 3, 10 }));

#endregion

#region JumpGame_55

//Console.WriteLine(JumpGame_55.CanJump(new int[] { 2,0,0 }));

#endregion

#region JumpGameII_45

//Console.WriteLine(JumpGameII_45.MinimumJump(new int[] { 1 }));

#endregion

#region FindTheHighestAltitude

//Console.WriteLine(FindTheHighestAltitude.LargestAltitude(new int[] { -4, -3, -2, -1, 4, 3, 2 }));

#endregion

#region MajorityElementII_229

//Console.WriteLine(MajorityElementII_229.MajorityElement(new int[] { 3, 2, 3 }));

#endregion

#region Sort0And1

//Sort0And1.Sort01(new int[] { 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1 });

#endregion

#region SortArrayByParity_905

//Console.WriteLine(SortArrayByParity_905.SortArrayByParity(new int[] { 3,1,2,4 }));

#endregion

#region SortArrayByParity_905

//SortColors_75.SortColors(new int[] { 2, 0, 2, 1, 1, 0 });

#endregion

#region KRadiusSubarrayAverages_2090

//Console.WriteLine(KRadiusSubarrayAverages_2090.GetAverages(new int[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 }, 3));

#endregion

#region RotateImage_48
var matrix = new int[3][];
int count = 1;
for (int i = 0; i < matrix.Length; i++)
{
    matrix[i] = new int[3]; // Create inner array
    for (int j = 0; j < matrix[i].Length; j++)
    {
        matrix[i][j] = count;
        count++;
    }

}
//RotateImage_48.Rotate(matrix);

#endregion

#region _3SumClosest_16

//Console.WriteLine(_3SumClosest_16.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1));

#endregion

#region WordSearch_79
char[] wordarray = new char[] { 'A', 'B', 'C', 'E', 'S', 'F', 'C', 'S', 'A', 'D', 'E', 'E' };
var wordMatrix = new char[3][];
count = 0;
for (int i = 0; i < wordMatrix.Length; i++)
{
    wordMatrix[i] = new char[4]; // Create inner array
    for (int j = 0; j < wordMatrix[i].Length; j++)
    {
        wordMatrix[i][j] = wordarray[count];
        count++;
    }

}


//Console.WriteLine(WordSearch_79.Exist(wordMatrix, "ABCCED"));

#endregion

#region BestTimeToBuyAndSellStockWithTransactionFee_714

//Console.WriteLine(BestTimeToBuyAndSellStockWithTransactionFee_714.MaxProfit(new int[] { 1, 3, 2, 8, 4, 9 },3));

#endregion

#region HouseRobber_198

//Console.WriteLine(HouseRobber_198.Rob(new int[] { 1, 2, 3, 1 }));

#endregion

#region RemoveDuplicatesFromSortedArrayII_80

//Console.WriteLine(RemoveDuplicatesFromSortedArrayII_80.RemoveDuplicates(new int[] { 1, 1, 1, 2, 2, 3 }));

#endregion

#region BestTimeToBuyAndSellStockII_122

//Console.WriteLine(BestTimeToBuyAndSellStockII_122.MaxProfit(new int[] { 1, 2, 3, 4, 5 }));

#endregion

#region RemoveDuplicatesFromSortedArray_26

//Console.WriteLine(RemoveDuplicatesFromSortedArray_26.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));

#endregion

#region RotateArray_189

//RotateArray_189.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);

#endregion

#region HIndex_274

//Console.WriteLine(HIndex_274.HIndex(new int[] { 3,1,2,3,2 }));

#endregion

#region ProductOfArrayExceptSelf_238

//Console.WriteLine(ProductOfArrayExceptSelf_238.ProductExceptSelf(new int[] { 1, 2, 3, 4 }));

#endregion

#region ReverseWordsInAString_151

//Console.WriteLine(ReverseWordsInAString_151.ReverseWords("the sky is blue"));

#endregion

#region LengthOfLastWord_58

//Console.WriteLine(LengthOfLastWord_58.LengthOfLastWord("the sky is blue"));

#endregion

#region FindTheIndexOfTheFirstOccurrenceInAString_28

//Console.WriteLine(FindTheIndexOfTheFirstOccurrenceInAString_28.StrStr("sadbutsad", "sad"));

#endregion

#region BuddyStrings_859

//Console.WriteLine(BuddyStrings_859.BuddyStrings.("aabcd", "aadcb"));

#endregion

#region SearchInRotatedSortedArray_33

//Console.WriteLine(SearchInRotatedSortedArray_33.Search(new int[] {3,1}, 1));

#endregion


#region MinimizedMaximumOfProductsDistributedToAnyStore_2064

//Console.WriteLine(MinimizedMaximumOfProductsDistributedToAnyStore_2064.MinimizedMaximum(6, new int[] { 11, 6 }));

#endregion

#region AddBinary_67
// not clear
//Console.WriteLine(AddBinary_67.AddBinary("1010", "1011"));

#endregion

#region FindFirstAndLastPositionOfElementInSortedArray_34

//var test = FindFirstAndLastPositionOfElementInSortedArray_34.SearchRange(new int[] { 1, 4 }, 4);
//foreach (var item in test)
//{
//    Console.Write(item + ", ");
//}

#endregion

#region SearchnRotatedSortedArrayII_81

//Console.WriteLine(SearchnRotatedSortedArrayII_81.Search(new int[] { 1, 0, 1, 1, 1 }, 0));

#endregion

#region MinimumNumberOfDaysToMakemBouquets_1482

Console.WriteLine(MinimumNumberOfDaysToMakemBouquets_1482.MinDays(new int[] { 7, 7, 7, 7, 12, 7, 7 }, 2,3));

#endregion

Console.ReadLine();


public class AddBinary_67
{
    public static string AddBinary(string a, string b)
    {
        int carry = 0;
        string result = "";
        // adding zeros to the shortest number's left for iteration 
        if (a.Length < b.Length)
            a = a.PadLeft(b.Length, '0');
        else
            b = b.PadLeft(a.Length, '0');

        for (int i = a.Length - 1; i >= 0; i--)
        {
            var tempA = char.GetNumericValue(a[i]);
            var tempB = char.GetNumericValue(b[i]);
            // now get mod 2 for getting the binary sum
            result = ((carry + tempA + tempB) % 2) + result;
            //you need to calculate the carry for next iteration with 
            //total sum is bigger or equal then 2 if its correct assign to 1
            carry = (carry + tempA + tempB) >= 2 ? 1 : 0;
        }
        //if carry has 1 then return result with carry, else just return result.
        return carry != 0 ? carry + result : result;
    }
}


public class MinimumNumberOfDaysToMakemBouquets_1482
{
    public static int MinDays(int[] bloomDay, int m, int k)
    {
        // in this problem we will going to use binary search
        // first we need to decide the range based on the days the flower need to bloom
        // take the max and min 
        // [1,10,3,10,2], bouquet m = 3, number of flowers in the bouquet k = 1
        // range will be 1 to 10 , so basically in this range we have all bloomed flower and possibally we can make the required number of bouquet
        // then we will take the mid and check if the mid can give us possible answer or not
        // if not then we will increase / decrease the range 

        // check if we dont have enough flowers in the garden to make the bouquet
        if (m * k > bloomDay.Length)
            return -1;
        int result = -1;
        int high = bloomDay.Max(), low = bloomDay.Min();
        while (low <= high)
        {
            int mid = (high + low) / 2;
            
            if (IsPossible(bloomDay, m, k, mid))
            {
                result = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
                
        }

        return result;
    }

    private static bool IsPossible(int[] flowerBloomDays, int bouquet, int flowersInEachBouquet, int range)
    {
        // adding two variable for tracking if we are able to make required bouquet(bc)
        // and if both the flowers are adjusent and bloomed
        int adjuset = 0;
        int bc = 0; // bouquetCount
        for (int i = 0; i < flowerBloomDays.Length; i++)
        {
            // if i th element is lesser then the day then the flower will bloom
            if (flowerBloomDays[i] <= range)
            {
                // this means we can now have one flower 
                adjuset++;

                // now ckeck if we have required number of adjusant flower
                if(adjuset == flowersInEachBouquet)
                {
                    bc++;
                    if (bc == bouquet)
                        return true;
                    else
                        // as i have created the boquet so we need to now reset
                        adjuset = 0;
                }
            }
            else
            {
                // now if the bouquet count is not equal to the required number of flower then will make the adjust to 0 
                // because we have break the continuity, ( adjusent means the flower should be contiguous)
                adjuset = 0;
            }
        }
        return false;
    }
}