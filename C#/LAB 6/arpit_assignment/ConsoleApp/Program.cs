using System;
using core;
using infrastructure;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            inventory obj = new inventory();
            Console.WriteLine(obj.ToString());
            obj.AddProduct("bucket",250,"green");
            Console.WriteLine(obj.ToString());
            //obj.gsgdh();
            product pd = new product { 
            Title="zero",
            Price=450,
            Color="grey"};
            pd.gsgdh();
        }
    }
}
