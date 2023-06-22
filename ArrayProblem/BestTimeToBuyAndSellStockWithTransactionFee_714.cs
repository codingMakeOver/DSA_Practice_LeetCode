namespace ArrayProblem;

public class BestTimeToBuyAndSellStockWithTransactionFee_714
{
    public static int MaxProfit(int[] prices, int fee)
    {
        //in the problem we will check two condition for buy ans sell and keep the data in a list's 0th ans 1th position 
        // in 0th we will keep the buy and 1th we will be keeping sell 
        // then we will take the max ,what value we will be getting by holding the value and what we will be getting by buying/selling the stock
        // ** when we will be buying we will be using negative
        // in this list will have the best buy and sell value of each day
        // the length will same as the prices

        List<List<int>> stockProfit = new List<List<int>>
        {
            //initialize initial value 
            // we will start considering by buying the day 1 stock as we don't have any stock till now
            new List<int>()
            {
                -(prices[0] + fee),// buying row
                0 // selling row . it is 0 as we have not considered the next day stock yet and you can not buy and sell on the same day
            }
        };

        // we will be start iterating from day 2 as we filled the day 1 value as initial value
        for (int i = 1; i < prices.Length; i++)
        {

            #region start filling the buy table
            // if we hold the stock, then we will just take the value of previous day
            int previousDayBuyValue = stockProfit[i - 1][0];
            // if we buy the stock of that day, then we will be calculating profit from last days sell - todays buy - transaction fee
            int buyProfit = stockProfit[i - 1][1] - (prices[i] + fee);
            // now we need to calculate which one will be profitable , either holding or buying
            int maxProfitInBuy = Math.Max(buyProfit, previousDayBuyValue);

            #endregion

            #region start filling the sell table
            // if we hold the stock, then we will just take the value of previous day
            int previousDaySellValue = stockProfit[i - 1][1];
            // if we sell the stock of that day, then we will be calculating profit from last days buy + todays buy 
            int sellProfit = stockProfit[i - 1][0] + prices[i];
            // now we need to calculate which one will be profitable , either holding or buying
            int maxProfitInSell = Math.Max(sellProfit, previousDaySellValue);

            #endregion
            stockProfit.Add(new List<int>
            {
                maxProfitInBuy,
                maxProfitInSell
            });
        }
        // return the last day profit
        return stockProfit.Last()[1];


        // Solution 2
        int len = prices.Length;
        int[] buy = new int[len];
        int[] sell = new int[len];

        buy[0] = -prices[0];

        for (int i = 1; i < len; i++)
        {
            buy[i] = Math.Max(buy[i - 1], sell[i - 1] - prices[i]);
            sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i] - fee);
        }

        return sell[len - 1];
    }
}
