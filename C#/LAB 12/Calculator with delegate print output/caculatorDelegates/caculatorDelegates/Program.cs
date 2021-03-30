using System;


namespace caculatorDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deligate Demo");
            Base b = new Base
            {
                a = 4,
                b = 5
            };
            calc pd = new calc(b.add);
            pd += b.mul;
            pd += b.div;
            pd += b.mod;
            pd += b.sub;

            b.printResult(pd);



            
        }
    }
}
