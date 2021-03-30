using System;
using System.Collections.Generic;
using System.Text;

namespace calculatorlib
{
    public class cal
    {
        private int res;
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int add()
        {
            int res = num1 + num2;
            return res;
        } 
        public int sub()
        {
            int res = num1 - num2;
            return res;
        }
    }
}
