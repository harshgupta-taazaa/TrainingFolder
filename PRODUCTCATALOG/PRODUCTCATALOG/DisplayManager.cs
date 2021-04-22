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
            if (EnteredKey.ToLower() == "b")

            {

                DisplayProductSection();

            }
            else if (EnteredKey.ToLower() == "a")
            {
                DisplayCategorySection();
            }
            else if (EnteredKey.ToLower() == "c")
            {
                Console.Clear();
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
            if (EnterKey.ToLower() == "a")
            {
                productmanager.AddItems();
                productmanager.ShowItems();
                Level1();
            }
            else if (EnterKey.ToLower() == "b")
            {
                productmanager.ShowItems();
                Level1();
            }

            else if (EnterKey.ToLower() == "c")
            {
                productmanager.DeleteProduct();
                Level1();
            }
            else if (EnterKey.ToLower() == "d")
            {
                productmanager.SearchProduct();
                Level1();
            }
        }

        public void DisplayCategorySection()
        {
            Console.WriteLine("\t a. Enter a Category.");
            Console.WriteLine("\t b. List all Categories ");
            Console.WriteLine("\t c. Delete a Category");
            Console.WriteLine("\t d. Search a Category");


            string category = Console.ReadLine();
            if (category == "a")
            {
                categorymanager.AddCategory();
                Level1();
            }
            else if (category == "b")
            {
                categorymanager.CategoryDetails();
                Level1();

            }
            else if (category == "c")
            {
                categorymanager.DeleteCategory();
                Level1();
            }
            else if (category == "d")
            {
                categorymanager.SearchCategory();
                Level1();
            }

        
        
        }
    }
}
