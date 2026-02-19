namespace CSPS.Problems
{
    internal class Build_an_Array_With_Stack_Operations : IProblem
    {
        public string Result
        {
            get
            {
                int[] target = [1, 2];
                int n = 4;
                var result = BuildArray(target, n);
                return string.Join(", ", result);
            }
        }
        public IList<string> BuildArray(int[] target, int n)
        {
            int[] stream = Enumerable.Range(1, n).ToArray();
            IList<string> operations = [];
            for (int i = 0; i < n; i++)
            {
                if (target.Contains(stream[i]))
                {
                    operations.Add("Push");
                }
                else if (stream[i] > target.Last())
                {
                    break;
                }
                else
                {
                    operations.Add("Push");
                    operations.Add("Pop");
                }
            }
            return operations;

        }
    }
}
