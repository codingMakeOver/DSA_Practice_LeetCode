namespace ArrayProblem;

public class FindTheHighestAltitude
{
    public static int LargestAltitude(int[] gain)
    {
        // we need to find the maximum gain of the bike
        // for getting the gain we will create a find the gain in each index and update the gain array with the value
        // netGain += gain[i]; gain[i] = netGain;
        // now if we sort the gain array in descending order then the highest gain element will be in the first position: ans
        if (gain == null)
            return 0;
        int netGain = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            netGain += gain[i];
            gain[i] = netGain;
        }

        netGain = gain.OrderByDescending(x => x).First();
        return netGain < 0 ? 0 : netGain;

        // solution 2
        //int max = 0, netgain = 0;

        //for (int i = 0; i < gain.Length; i++)
        //{
        //    netgain += gain[i];
        //    max = Math.Max(max, netgain);
        //}
        //return max;
    }
}
