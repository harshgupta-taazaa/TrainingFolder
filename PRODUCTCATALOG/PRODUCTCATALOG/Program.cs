using System;
using System.Collections.Generic;

namespace PRODUCTCATALOG
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductList p1 = new ProductList();
            CategorySection c1 = new CategorySection();
            Console.WriteLine("Level 1");
            Console.WriteLine("\t a)- Category");
            Console.WriteLine("\t b)- Product");
            Console.WriteLine("\t c)- Exit the App!");
            Console.WriteLine("Enter a key ....");
            string EnteredKey = Console.ReadLine();

            //p1.ListOfItems.Add(new Product { Price = 30, ProductId = 4, ProductName="book" });

            if (EnteredKey.ToLower() == "b")

            {
                Console.WriteLine("\t a. Enter a Product.");
                Console.WriteLine("\t b. List all products. ");
                Console.WriteLine("\t c. Delete a Product");
                Console.WriteLine("\t d. Search a Product");
                string EnterKey = Console.ReadLine();
                if (EnterKey.ToLower() == "a")
                {
                    p1.AddItems();
                    p1.ShowItems();
                }
                else if (EnterKey.ToLower() == "b")
                {
                    p1.ShowItems();
                }

                else if (EnterKey.ToLower() == "c")
                {
                    p1.DeleteProduct();
                }
                else if (EnterKey.ToLower() == "d")
                {
                    p1.SearchProduct();

                }



            }
            else if (EnteredKey.ToLower() == "a")
            {
                Console.WriteLine("\t a. Enter a Category.");
                Console.WriteLine("\t b. List all Categories ");
                Console.WriteLine("\t c. Delete a Category");
                Console.WriteLine("\t d. Search a Category");


                string category = Console.ReadLine();
                if (category == "a")
                {
                    c1.AddCategory();
                }
                else if (category == "b")
                {
                    c1.CategoryDetails();

                }
                else if (category == "c")
                {
                    c1.DeleteCategory();
                }
                else if (category == "d")
                {
                    c1.SearchCategory();
                }

            }
            else if (EnteredKey.ToLower() == "c")
            {

            }
        }
    }
}
