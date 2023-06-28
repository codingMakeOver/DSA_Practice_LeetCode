namespace PriorityQueue;

public class TotalCostToHireKWorkers_2462
{
    public static long TotalCost(int[] costs, int k, int candidates)
    {
        PriorityQueue<int, int> leftQ = new PriorityQueue<int, int>();
        PriorityQueue<int, int> rightQ = new PriorityQueue<int, int>();
        long totalCost = 0;
        int l=0, r = costs.Length - 1;

        // will run the loop till k as k session needs to performed
        for (int i = 0; i < k; i++)
        {
            // adding element to left priority queue
            // here will run loop until we take the required candidate and l <= r
            while (leftQ.Count < candidates && l <= r)
            {
                // here we will be adding the cost of the particular index
                // and the priority will be denoted by the indexed value
                // like if value is 5 its priority will be 5 and if 2 then priority will be 2
                // this way we can have element in the heap with there priority
                leftQ.Enqueue(costs[l], costs[l]);
                l++;
            }

            // adding element to left priority queue
            while (rightQ.Count < candidates && r >= l)
            {
                rightQ.Enqueue(costs[r], costs[r]);
                r--;
            }

            // now will check if the queue has some value then pick the top priority element else maxvalue as default value(because we need to later compare this value and need to pick the smaller that's why making default value max so this default value can be eliminated)
            // if in the queue have 3 element like 
            // value  priority
            // 5      5
            // 2      2
            // 4      4
            // so now if we pick the top priority when 2 will be picked
            int leftPriorityValue = leftQ.Count > 0 ? leftQ.Peek() : int.MaxValue;
            int rightPriorityValue = rightQ.Count > 0 ? rightQ.Peek() : int.MaxValue;

            if(leftPriorityValue <= rightPriorityValue)
            {
                totalCost += leftPriorityValue;
                // Dequeue will remove the priority element from the queue
                leftQ.Dequeue();
            }
            else
            {
                totalCost += rightPriorityValue;
                rightQ.Dequeue();
            }
        }

        return totalCost;
    }
}
