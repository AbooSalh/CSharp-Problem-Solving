namespace CSPS.Problems
{
    internal class _345 : IProblem
    {
        public string Result
        {
            get
            {
                _345 p = new _345();
                return p.ReverseVowels("hello");
            }
        }
        public string ReverseVowels(string s)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u' , 'A', 'E', 'I', 'O', 'U'];
            char[] charsOfString = s.ToCharArray();
            Stack<char> chars = [];

            for (int i = 0; i < s.Length; i++)
            {
                char currentCharOfStr = charsOfString[i];
                if (vowels.Contains(currentCharOfStr))
                {
                    chars.Push(currentCharOfStr);
                }

            }

            _ = chars.Reverse();
            
            for (int i = 0; i < s.Length; i++)
            {
                char currentCharOfStr = charsOfString[i];                
                if (vowels.Contains(currentCharOfStr))
                {
                    charsOfString[i] = chars.Pop();

                }
                else
                {
                    charsOfString[i] = currentCharOfStr;
                }
            }

            return new string(charsOfString);
        }
    }
}
