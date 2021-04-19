using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class CategorySection
    {
        ProductList p1 = new ProductList();

        public List<string> Categories = new List<string> {"fruits","stationary"};
        public void CategoryDetails()
        {
            foreach (Product p in p1.ListOfItems)
            {
                Console.WriteLine(p.CategoryName);
            }
        }
        public void SearchCategory()
        {
            string EnterCategory = Console.ReadLine();
             foreach (Product p in p1.ListOfItems)
            {
                if (EnterCategory == p.CategoryName)
                {
                    Console.WriteLine(" Id : " + p.ProductId + " Product Name : " + p.ProductName + " Price : " + p.Price +" category:" + p.CategoryName);
                }
            }
        }
        public void DeleteCategory()
        {
            //Console.WriteLine("Enter Id to delete");
            //int id = Convert.ToInt32(Console.ReadLine());
            //p1.ListOfItems.Reverse();
            //string Delete = Console.ReadLine();
            //foreach (Product p in p1.ListOfItems)
            //{
            //    if (Delete == p.CategoryName)
            //    {
            //        Console.WriteLine(p.ProductId);
            //        p1.ListOfItems.RemoveAt(3);

            //    }


            //}
            
            for (int i = p1.ListOfItems.Count - 2; i >= 0; i--)
            {
                p1.ListOfItems.RemoveAt(i);
            }
           
                p1.ShowItems();
        }

        public void AddCategory()
        {
            Console.WriteLine("enter a category name");
            string s = Console.ReadLine();
            Categories.Add(s);
            Console.WriteLine("Available Categories");
            foreach(string str in Categories)
            {
                Console.WriteLine(str);
            }
        }
    }
}
