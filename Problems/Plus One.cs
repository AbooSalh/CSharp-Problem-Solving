namespace CSPS.Problems
{
    internal class Plus_One : IProblem
    {
        public string Result
        {
            get
            {
                int[] digits = [1, 2, 9];
                return string.Join(", ", PlusOne(digits));
            }
        }
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[digits.Length + 1];
            newNumber[0] = 1;
            return newNumber;

        }
    }
}
