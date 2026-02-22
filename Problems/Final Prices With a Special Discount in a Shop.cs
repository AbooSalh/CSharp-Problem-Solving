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
        public int[] FinalPrices(int[] prices)
        {
            int[] result = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                int discount = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        discount = prices[j];
                        break;
                    }
                }
                result[i] = prices[i] - discount;
            }

            return result;
        }
        //public int[] FinalPrices(int[] prices)
        //{
        //    Stack<int> stack = new();
        //    int[] answer = new int[prices.Length];
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
        //        {
        //            int index = stack.Pop();
        //            answer[index] = prices[index] - prices[i];
        //        }
        //        stack.Push(i);
        //    }
        //    while (stack.Count > 0)
        //    {
        //        int index = stack.Pop();
        //        answer[index] = prices[index];
        //    }
        //    return answer;
        //}
    }
}
