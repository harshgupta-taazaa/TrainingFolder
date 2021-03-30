using System;
using System.Collections.Generic;
using System.Text;

namespace caculatorDelegates
{
    public delegate void calc( );
    public class Base
    {
        public decimal a { get; set; }
        public decimal b { get; set; }
        public void add()
        {
            var v = a + b;
            Console.WriteLine($"Addition is : {v}");
        }
        public void mul()
        {
            var v = a * b;
            Console.WriteLine($"Multiplication is : {v}");
        }
        public void sub()
        {
            var v = a - b;
            Console.WriteLine($"Subtraction is : {v}");
        }
        public void div()
        {
            var v = a / b;
            Console.WriteLine($"Division is : {v}");
        }
        public void mod()
        {
            var v = a % b;
            Console.WriteLine($"Modulus is : {v}");
        }

        public void printResult(calc c)
        {
          
            c();
            
            
        }



    }
}
