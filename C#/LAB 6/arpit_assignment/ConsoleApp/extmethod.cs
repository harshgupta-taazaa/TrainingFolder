using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace ConsoleApp
{
   public static class extmethod
    {
        public static void gsgdh(this product p) {
            Console.WriteLine("Title : "+p.Title+" -> Price : "+ p.Price+" -> Color : "+p.Color);
        }
    }
}
