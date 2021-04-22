using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class CategorySection
    {
        ProductList productuser = new ProductList();

        public List<string> Categories = new List<string> {"fruits","stationary"};
        public void CategoryDetails()
        {
            foreach (Product p in productuser.ListOfItems)
            {
                Console.WriteLine(p.CategoryName);
            }
        }
        public void SearchCategory()
        {
            string EnterCategory = Console.ReadLine();
             foreach (Product p in productuser.ListOfItems)
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
            
            for (int i = productuser.ListOfItems.Count - 2; i >= 0; i--)
            {
                productuser.ListOfItems.RemoveAt(i);
            }
           
                productuser.ShowItems();
        }

        public void AddCategory()
        {
            
            productuser.AddItems();
            productuser.ShowItems();
            
        }
    }
}
