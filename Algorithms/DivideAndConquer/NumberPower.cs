using CSPS.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Algorithms.DivideAndConquer
{
    internal class NumberPower : IProblem
    {
        public string Result
        {
            get
            {
                return Pow(2, 3).ToString();
            }
        }
        static int Pow(int a , int b)
        {
            if(b == 0)
            {
                return 1;
            }
            return a * Pow(a,b-1);
        }
    }
}
