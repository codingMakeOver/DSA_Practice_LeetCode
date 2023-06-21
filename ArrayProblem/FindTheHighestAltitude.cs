namespace ArrayProblem;

public class FindTheHighestAltitude
{
    public static int LargestAltitude(int[] gain)
    {
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
