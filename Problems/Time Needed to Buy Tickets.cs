namespace CSPS.Problems
{
    internal class Time_Needed_to_Buy_Tickets : IProblem
    {
        public string Result
        {
            get
            {
                int[] tickets = [2, 3, 2];
                int k = 2;
                return TimeRequiredToBuy(tickets, k).ToString();
            }
        }
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int time = 0;
            while (tickets[k] > 0)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] > 0)
                    {
                        tickets[i]--;
                        time++;
                    }
                    if (tickets[k] == 0)
                    {
                        break;
                    }
                }
            }
            return time;

        }
    }
}
