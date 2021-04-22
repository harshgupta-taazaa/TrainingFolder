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
            foreach (Product p in ProductList.ListOfItems)
            {
                Console.WriteLine("Id : "+ p.ProductId + "  Category : " + p.CategoryName);
            }
        }
        public void SearchCategory()
        {
            Console.WriteLine("Enter a category");
            string EnterCategory = Console.ReadLine();
            bool found = false;
             foreach (Product p in ProductList.ListOfItems)
            {
                if (EnterCategory.ToLower() == p.CategoryName.ToLower())
                {
                    found = true;
                    Console.WriteLine(" Id : " + p.ProductId + " Product Name : " + p.ProductName + " Price : " + p.Price +" category:" + p.CategoryName + " Short Code : " + p.ShortCode + " Description : " + p.Description);
                }
            }
            if (!found)
            {
                Console.WriteLine("NO items related to that category");
            }
        }
        public void DeleteCategory()
        {
            Console.WriteLine("Enter Category to delete");
            string Delete = Console.ReadLine();
            ProductList.ListOfItems.RemoveWhere(x => x.CategoryName == Delete);
            productuser.ShowItems();
        }


        public void AddCategory()
        {
            
            productuser.AddItems();
            productuser.ShowItems();
            
        }
    }
}
