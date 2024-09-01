namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class BestTimeToBuyAndSellStock_121
{
    public static int MaxProfit(int[] prices)
    {
        var maxSell = int.MaxValue;
        var maxProfit = 0;
        
        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < maxSell)
            {
                maxSell = prices[i];
                continue;
            }

            var result = prices[i] - maxSell;
            
            if (result > maxProfit)
            {
                maxProfit = result;
            }
        }

        return maxProfit;
    }
}