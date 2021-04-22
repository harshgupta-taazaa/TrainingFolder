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
                Console.WriteLine("Id : "+ p.ProductId + "  Category : " + p.CategoryName);
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
            Console.WriteLine("Enter Category to delete");
            string Delete = Console.ReadLine();
            productuser.ListOfItems.RemoveWhere(x => x.CategoryName == Delete);
            productuser.ShowItems();
        }

        public void AddCategory()
        {
            
            productuser.AddItems();
            productuser.ShowItems();
            
        }
    }
}
