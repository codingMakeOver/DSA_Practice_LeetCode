public class MinimizedMaximumOfProductsDistributedToAnyStore_2064
{
    public static int MinimizedMaximum(int n, int[] quantities)
    {
        // in this problem main constant is each shop must have atleaset one product and all product should be distributed
        // so will take the max value from the array and will check the answer from 1 to max value 
        // when we are searching in a range (means that is sorted) , the most optimized solution is binary search
        // now will take the mid and will check if the mid is full filling the requirement 
        // if not then we short the range => from 1 to mid - 1
        // we are doing this because if mid is not satisfying the condition then mid + 1 will definitely not satisfy the constants 
        // we always start from 1 as the shop should have atleast 1 product 

        // like shop = 6 and products = [11,6]
        // max = 11 and min = 1+11 / 2 = 6
        // now will start distributing 6 product to each shop 
        // 6, 11-6, 6, 0, 0, 0 so we are not able to give product to each store , so 6 will not be the answer
        // new range 1 to mid-1 => 6-1 = 5
        // mid = 1+5 /2 = 3
        // now if we start shareing 3 product then
        // 3,3,3,2,3,3 // so 3 is fullfilling the condition
        // mid = 1 + (oldmid(3) -1) => 1 + 2 /2 = 1
        // if we use 1 then we will not be able to distribute all the product
        // similerly if the 1 to mid range did not work will make new range and do the same
        // new range mid + 1 to high

        int low = 1, high = quantities.Max(), ans = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
           // will check if this mid will be the answer
           if(IsPossible(quantities, n, mid))
            {
                ans = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return ans;
    }

    private static bool IsPossible(int[] arr, int totalShop, int maxRange)
    {
        // initially set the store 0
        int shopCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            // take the first element of the array
            int quantity = arr[i];
            
            while (quantity > 0)
            {
                // checking if the element valid is grater then the mid value
                // means 11 is grater then 3(mid)
                if (quantity > maxRange)
                {
                    // then we will keep the reminign product after distributing the mid
                    // 3 will distributed to shop1 so shopCount++
                    // and now we will be 11-3 = 9 product
                    quantity -= maxRange;
                    shopCount++;
                }
                else
                {
                    // when this will be less that mid means we will be giving reminig products to the shop 
                    // so in 3 round , shop1 get 3, shop2 = 3 and shop3 = 3
                    // so now we have 11 - (3+3+3) = 2 product 
                    // we will be distributing to another shop so shopCount++
                    // now as we have distributed all arr[i] , will now make the quantity = 0
                    shopCount++;
                    quantity = 0;
                }
            }
        }
        return true;
    }
}