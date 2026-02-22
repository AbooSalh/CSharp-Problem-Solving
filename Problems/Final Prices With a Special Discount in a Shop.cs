namespace CSPS.Problems
{
    internal class Final_Prices_With_a_Special_Discount_in_a_Shop : IProblem
    {
        public string Result
        {
            get
            {
                int[] prices = [8, 4, 6, 2, 3];
                var result = FinalPrices(prices);
                return string.Join(", ", result);
            }
        }
        //public int[] FinalPrices(int[] prices)
        //{
        //    int[] result = new int[prices.Length];
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        int discount = 0;
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            if (prices[j] <= prices[i])
        //            {
        //                discount = prices[j];
        //                break;
        //            }
        //        }
        //        result[i] = prices[i] - discount;
        //    }

        //    return result;
        //}
        public int[] FinalPrices(int[] prices)
        {
            int n = prices.Length;
            Stack<int> stack = new();
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
                {

                    int prevIndex = stack.Pop();
                    result[prevIndex] = prices[prevIndex] - prices[i];
                }
                result[i] = prices[i]; // default price if no discount
                stack.Push(i);
            }
            return result;

        }
    }
}
