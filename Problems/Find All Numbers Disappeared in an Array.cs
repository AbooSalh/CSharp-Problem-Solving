namespace CSPS.Problems
{
    internal class Find_All_Numbers_Disappeared_in_an_Array : IProblem
    {
        public string Result
        {
            get
            {
                int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
                var result = FindDisappearedNumbers(nums);
                return string.Join(", ", result);
            }
        }
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            bool[] values = new bool[nums.Length + 1];
            //By default value if false, if we found value in our required range set value true
            foreach (var t in nums)
            {
                values[t] = true;
            }
            //collect all values which is not found in required range
            var result = new List<int>();
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == false)
                {
                    result.Add(i);
                }
            }
            //Console.WriteLine((string)string.Join(",", values));
            return result;
        }
    }
}
