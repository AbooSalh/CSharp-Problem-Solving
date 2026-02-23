namespace CSPS.Problems
{
    internal class Largest_Rectangle_in_Histogram : IProblem
    {
        public string Result
        {
            get
            {
                return LargestRectangleArea([2, 1, 5, 6, 2, 3]).ToString();
            }
        }
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int n = heights.Length;

            for (int i = 0; i <= n; i++)
            {
                int currentHeight = (i == n) ? 0 : heights[i];

                while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
                {
                    int h = heights[stack.Pop()];

                    int right = i;
                    int left = stack.Count == 0 ? -1 : stack.Peek();

                    int width = right - left - 1;
                    maxArea = Math.Max(maxArea, h * width);
                }

                stack.Push(i);
            }

            return maxArea;
        }
    }
}
