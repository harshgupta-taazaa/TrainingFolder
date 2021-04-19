using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class ProductList
    {
        public List<Product> ListOfItems = new List<Product>
        {
            new Product
            {
                Price=100,
                ProductName="rubber",
                ProductId=1,
                CategoryName="Stationary",
                Manufacturer="Extramarks"

            },
            new Product
                {
                    ProductId=2,
                    ProductName="pen",
                    Price=20,
                    CategoryName="Stationary",
                    Manufacturer="Cello"
                },
                new Product
                {
                    ProductId=3,
                    ProductName="pencil",
                    Price=10,
                    CategoryName="Stationary",
                    Manufacturer="Natraj"
                },
                 new Product
                {
                    ProductId=4,
                    ProductName="apple",
                    Price=100,
                    CategoryName="fruit",
                    Manufacturer="Rakesh Fruits"
                },
                 new Product
                {
                    ProductId=5,
                    ProductName="fan",
                    Price=2000,
                    CategoryName="Home Appliance",
                    Manufacturer="Bajaj"
                },
                 new Product
                {
                    ProductId=6,
                    ProductName="CHIPS",
                    Price=20,
                    CategoryName="Fast Food",
                    Manufacturer="Lays"
                },
                 new Product
                {
                    ProductId=7,
                    ProductName="Samsung A50",
                    Price=20000,
                    CategoryName="Smart Phone",
                    Manufacturer="Samsung"
                }

        };

        private static int id = 7;

        static int generateId()
        {
            return ++id;
        }
        public void ShowItems()
        {
            Console.WriteLine("Items Available");
            foreach (Product p in ListOfItems)
            {
                Console.WriteLine(p);
            }
        }

        public void AddItems()
        {

            //Console.WriteLine("Enter ProductID");
            Console.WriteLine("Enter Category");
            string Cat = Console.ReadLine();
            int id = generateId();
            Console.WriteLine("Enter ProductName");
            string name = Console.ReadLine();
            Console.WriteLine("Enter ProductPrice");
            int ProductPrice = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Manufacturer");
            string manu = Console.ReadLine();
            ListOfItems.Add(new Product { Price = ProductPrice, ProductId = id, ProductName = name , CategoryName=Cat , Manufacturer=manu });

        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter Id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            ListOfItems.RemoveAt(id - 1);
            ShowItems();
        }

        public void SearchProduct()
        {
            Console.WriteLine("Search Product ");
            string search = Console.ReadLine();
            Nullable<int> price = null;
            try
            {
                int a=Int16.Parse(search);
                price = a;
            }
            catch(Exception)
            {

            }
            foreach (Product p in ListOfItems)
            {
                if (search.ToLower()==p.ProductName || price <= p.Price)
                {
                    Console.WriteLine(" Id : " + p.ProductId + " Product Name : " + p.ProductName + " Price : "
                        + p.Price+" Manufacturer : " + p.Manufacturer);
                }
            }
        }
    }
}
