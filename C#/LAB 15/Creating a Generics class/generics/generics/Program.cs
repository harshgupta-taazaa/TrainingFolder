using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass<int> obj = new TestClass<int>();
            //obj.Add(5);
            //TestClass<Products> pd = new TestClass<Products>();
            //pd.Add(

            //    new Products
            //    {
            //        Id = 1,
            //        Title = "A",
            //        Price = 50
            //    }
            //    );
            Products a = new Products
            {
                Price = 100
            };
            Products b = new Products
            {
                Price = 10
        };
            
            //pd.Add(

            //   new Products
            //   {
            //       Id = 2,
            //       Title = "B",
            //       Price = 50
            //   }
            //   );
            //pd.Add(

            //   new Products
            //   {
            //       Id = 3,
            //       Title = "C",
            //       Price = 50
            //   }
            //   );
            //pd.Add(

            //   new Products
            //   {
            //       Id = 4,
            //       Title = "D",
            //       Price = 50
            //   }
            //   );
            //pd.Add(

            //   new Products
            //   {
            //       Id = 5,
            //       Title = "E",
            //       Price = 50
            //   }
            //   );
            //for (int i=0;i<5;i++)
            //{
            //    Console.WriteLine(obj[i]);
            //    Console.WriteLine(pd[i]);
            //}
           
            // swap in generics
            
            
            Console.WriteLine($" A= {a.Price} B ={b.Price}");
            swap<Products>(ref a, ref b);
            Console.WriteLine($" A= {a.Price} B ={b.Price}");
            static void swap <T>(ref T a,ref T b)
            {
                T temp;
                temp = a;
                a = b;
                b = temp;
            }
        }


    }
}
