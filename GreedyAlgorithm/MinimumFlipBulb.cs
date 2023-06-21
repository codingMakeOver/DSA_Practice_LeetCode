namespace GreedyAlgorithm;


/// <summary>
/// First solution 
/// </summary>
public static class MinimumFlipBulb
{
    public static int Bulbs(List<int> A)
    {
        int cost = 0;
        
        for (int i = 0; i < A.Count; i++)
        {
            if (cost % 2 != 0) A[i] = A[i] == 0 ? 1 : 0;

            if (A[i] != 1) cost++;
        }
        
        return cost;
    }

}

/// <summary>
/// Second solution
/// </summary>
class Solution
{
    public int bulbs(List<int> A)
    {
        var cost = 0;
        foreach (var needToOn in A)
        {
            // if the bulb is on and the cost is even then bulb is on 
            if (needToOn == 1 && cost % 2 == 0) continue;

            // if the bulb is on and the cost is odd then the bulb is off. We need to press the switch
            if (needToOn == 1 && cost % 2 != 0) cost++;

            // if the bulb is off and the cost is odd then the bulb is on 
            if (needToOn == 0 && cost % 2 != 0) continue;

            // if the bulb is off and the current state is even then the bulb is off.  We need to press the switch
            if (needToOn == 0 && cost % 2 == 0) cost++;
        }
        return cost;
    }
}
