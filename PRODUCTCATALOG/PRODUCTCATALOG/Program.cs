using System;
using System.Collections.Generic;

namespace PRODUCTCATALOG
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductList productmanager = new ProductList();
            CategorySection categorymanager = new CategorySection();
            DisplayManager Display = new DisplayManager();

            Display.Level1();
        //    Console.WriteLine("Level 1");
        //    Console.WriteLine("\t a)- Category");
        //    Console.WriteLine("\t b)- Product");
        //    Console.WriteLine("\t c)- Exit the App!");
        //    Console.WriteLine("Enter a key ....");
        //    string EnteredKey = Console.ReadLine();

        //    //p1.ListOfItems.Add(new Product { Price = 30, ProductId = 4, ProductName="book" });

        //    if (EnteredKey.ToLower() == "b")

        //    {

        //        Display.DisplayProductSection();

        //    }
        //    else if (EnteredKey.ToLower() == "a")
        //    {
        //        Console.WriteLine("\t a. Enter a Category.");
        //        Console.WriteLine("\t b. List all Categories ");
        //        Console.WriteLine("\t c. Delete a Category");
        //        Console.WriteLine("\t d. Search a Category");


        //        string category = Console.ReadLine();
        //        if (category == "a")
        //        {
        //            categorymanager.AddCategory();
        //        }
        //        else if (category == "b")
        //        {
        //            categorymanager.CategoryDetails();

        //        }
        //        else if (category == "c")
        //        {
        //            categorymanager.DeleteCategory();
        //        }
        //        else if (category == "d")
        //        {
        //            categorymanager.SearchCategory();
        //        }

        //    }
        //    else if (EnteredKey.ToLower() == "c")
        //    {
        //        Console.Clear();
        //    }
        }
    }
}
