using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class _455 : IProblem
    {
        public string Result
        {
            get
            {
                int[] g = [1,2,3];
                int[] s = [1];
                return FindContentChildren(g,s).ToString();
            }
        }
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            // pointers
            int i = 0;
            int j = 0;

            while (i< g.Length && j< s.Length)
            {
                if(s[j] >= g[i])
                {
                    i++;
                }
                j++;
            }
            return i;
        }
    }
}
