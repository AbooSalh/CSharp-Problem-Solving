using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class _1768 : IProblem
    {
        public string Result
        {
            get
            {
                string word1 = "abccc";
                string word2 = "pqr";
                return MergeAlternately(word1, word2);
            }
        }
        public static string MergeAlternately(string word1, string word2)
        {
            int w1L = word1.Length;
            int w2L = word2.Length;
            int mergedLength = w1L + w2L;
            char[] mergedChars = new char[mergedLength];

            int w1Pointer = 0;
            int w2Pointer = 0;
            int mergedCharsPointer = 0;
            int counter = 2;


            while (w1Pointer < w1L  && w2Pointer < w2L)
            {
                if (counter++ % 2 == 0)
                {
                    mergedChars[mergedCharsPointer++] = word1[w1Pointer];
                    w1Pointer++;
                    
                }
                else
                {
                    mergedChars[mergedCharsPointer++] = word2[w2Pointer];
                    w2Pointer++;
                }
            }


            while(w1Pointer < w1L)
            {
                mergedChars[mergedCharsPointer++] = word1[w1Pointer++];
            }
            while (w2Pointer < w2L)
            {
                mergedChars[mergedCharsPointer++] = word2[w2Pointer++];
            }

            return string.Join("", mergedChars);
        }
    }
}
