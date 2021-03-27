using System;
using System.Collections.Generic;
using System.Text;

namespace calculatordelegate
{
    public class Operation
    {
        public delegate int Operate(int a, int b);
        public int ReturnResult(Operate p , int a , int b)
        {
            int result = p(a, b);
            return result;

            
        }

    }
}
