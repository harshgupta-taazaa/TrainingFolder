using System;

namespace calculatordelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating...");
            Add a = new Add();
            Operation k = new Operation();
            Substract b = new Substract();
            Multiply c = new Multiply();
            Operation.Operate d = a.AddResult;

            Console.WriteLine( k.ReturnResult(d, 2, 4));

            Operation.Operate r = b.SubResult;

            Console.WriteLine(k.ReturnResult(r, 2, 4));


            Console.ReadKey(true);

        }
    }
}
