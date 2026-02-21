namespace CSPS.Problems
{
    internal class Exclusive_Time_of_Functions : IProblem
    {
        public string Result
        {
            get
            {
                int n = 2;
                IList<string> logs = ["0:start:0", "1:start:2", "1:end:5", "0:end:6"];
                var result = ExclusiveTime(n, logs);
                return string.Join(", ", result);
            }
        }
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            Stack<(int id, int start)> stack = new();
            int[] answer = new int[n];

            foreach (var log in logs)
            {
                var entry = log.Split(':');
                int currentId = Int32.Parse(entry[0]);
                int time = Int32.Parse(entry[2]);

                // check if its the start if so, push on stack
                if (entry[1] == "start")
                {
                    // check if there is a parent function function that is executing
                    // if so, add the execution time till it was paused
                    if (stack.Count > 0)
                    {
                        var parent = stack.Peek();
                        answer[parent.id] += time - parent.start;
                    }

                    stack.Push((currentId, time));
                }
                else
                {
                    var currentFunction = stack.Pop();
                    answer[currentFunction.id] += time - currentFunction.start + 1;

                    // update the start of the parent function
                    // as it resumed the execution
                    if (stack.Count > 0)
                    {
                        var parent = stack.Pop();
                        stack.Push((parent.id, time + 1));
                    }
                }
            }

            return answer;
        }
    }
}
