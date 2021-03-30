using System;

namespace SimpleExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            var a = e.Compile();
            Console.WriteLine(a(7)) ;
        }
    }
}
