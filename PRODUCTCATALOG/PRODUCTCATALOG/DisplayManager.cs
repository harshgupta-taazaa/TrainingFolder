using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class DisplayManager
    {
        ProductList productmanager = new ProductList();
        CategorySection categorymanager = new CategorySection();

        public void Level1()
        {
            Console.WriteLine("Level 1");
            Console.WriteLine("\t a)- Category");
            Console.WriteLine("\t b)- Product");
            Console.WriteLine("\t c)- Exit the App!");
            Console.WriteLine("Enter a key ....");
            string EnteredKey = Console.ReadLine();

            switch (EnteredKey)
            {
                case "a":
                    DisplayCategorySection();
                    break;
                case "b":
                    DisplayProductSection();
                    break;
                case "c":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Key ......");
                    Console.WriteLine("To Go Back PRESS 1 or any other key to exit app");
                    string User = Console.ReadLine();
                    if (User == "1")
                    {
                        Level1();
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;
            }
        }

        public void DisplayProductSection()
        {
            Console.WriteLine("\t a. Enter a Product.");
            Console.WriteLine("\t b. List all products. ");
            Console.WriteLine("\t c. Delete a Product");
            Console.WriteLine("\t d. Search a Product");
            Console.WriteLine("Enter a Key..");
            string EnterKey = Console.ReadLine();

            switch (EnterKey)
            {
                case "a":
                    productmanager.AddItems();
                    productmanager.ShowItems();
                    Level1();
                    break;
                case "b":
                    productmanager.ShowItems();
                    Level1();
                    break;
                case "c":
                    productmanager.DeleteProduct();
                    Level1();
                    break;
                case "d":
                    productmanager.SearchProduct();
                    Level1();
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Key ......");
                    Console.WriteLine("To Go Back PRESS 1 or any other key to exit app");
                    string User = Console.ReadLine();
                    if (User == "1")
                    {
                        DisplayProductSection();
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;
            }
        }

        public void DisplayCategorySection()
        {
            Console.WriteLine("\t a. Enter a Category.");
            Console.WriteLine("\t b. List all Categories ");
            Console.WriteLine("\t c. Delete a Category");
            Console.WriteLine("\t d. Search a Category");


            string category = Console.ReadLine();

            switch (category)
            {
                case "a":
                    categorymanager.AddCategory();
                    Level1();
                    break;
                case "b":
                    categorymanager.CategoryDetails();
                    Level1();

                    break;
                case "c":
                    categorymanager.DeleteCategory();
                    Level1();
                    break;
                case "d":
                    categorymanager.SearchCategory();
                    Level1();
                    break;
                default:
                    Console.WriteLine("You have Entered Wrong Key ......");
                    Console.WriteLine("To Go Back PRESS 1 or any other key to exit app");
                    string User = Console.ReadLine();
                    if (User == "1")
                    {
                        DisplayCategorySection();
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;
            }
            
        }
    }
}
