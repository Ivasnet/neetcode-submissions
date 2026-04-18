public class Solution {
    public int MaxProfit(int[] prices) {
        var maxDelta = 0;
        var cheapest = int.MaxValue;
        var richest = 0;
         
        for (var i = 0; i < prices.Length; i++)
        {
            if (cheapest != int.MaxValue && prices[i] > richest && prices[i] > cheapest)
            {
                richest = prices[i];
                if (richest - cheapest > maxDelta)
                {
                    maxDelta = richest - cheapest;
                }
            }
            else if (prices[i] < cheapest)
            {
                cheapest = prices[i];
                richest = 0;
            }
        }

        return maxDelta;
    }
}
