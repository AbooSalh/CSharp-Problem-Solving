using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class Daily_Temperatures : IProblem
    {
        public string Result
        {
            get
            {
                int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
                var result = DailyTemperatures(temperatures);
                return string.Join(", ", result);
            }
        }
        public int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] answer = new int[n];
            Stack<int> stack = new(); // stores indices

            for (int i = 0; i < n; i++)
            {
                // Resolve previous colder days
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    answer[prevIndex] = i - prevIndex;
                }

                // Push current day
                stack.Push(i);
            }

            return answer;
        }
    }
}
