using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Entity
{
    public class Inventory
    {

        public static HashSet<Products> ListOfItems= new HashSet<Products>();

        public static HashSet<Products> OrderList = new HashSet<Products>();

        public static void ShowListOfItemsAvailable()
        {
            Console.WriteLine("Items Available");
            foreach(Products p in ListOfItems)
            {
                Console.WriteLine(p);
            }
        }

        
    }
}
