namespace ArrayProblem;

public class GasStation_134
{
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        // if you oil is less then you kilometer then return -1
        if(gas.Sum() < cost.Sum()) return -1;

        int ans = 0, fuleRemaining = 0;
        for (int i = 0; i < cost.Length; i++)
        {
            fuleRemaining = fuleRemaining + gas[i] - cost[i];
            if (fuleRemaining < 0)
            {
                ans = i + 1;
                fuleRemaining = 0;
            }
        }
        return ans;
    }
}
