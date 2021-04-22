using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class ProductList
    {
        int ProductPrice;
        public List<Product> ListOfItems = new List<Product>
        {
            new Product
            {
                Price=100,
                ProductName="rubber",
                ProductId=1,
                CategoryName="Stationary",
                Manufacturer="Extramarks",
                ShortCode="rb"

            },
            new Product
                {
                    ProductId=2,
                    ProductName="pen",
                    Price=20,
                    CategoryName="Stationary",
                    Manufacturer="Cello",
                    ShortCode="pn"
                },
                new Product
                {
                    ProductId=3,
                    ProductName="pencil",
                    Price=10,
                    CategoryName="Stationary",
                    Manufacturer="Natraj",
                    ShortCode="pncl"
                },
                 new Product
                {
                    ProductId=4,
                    ProductName="apple",
                    Price=100,
                    CategoryName="fruit",
                    Manufacturer="Rakesh Fruits",
                    ShortCode="ap"
                },
                 new Product
                {
                    ProductId=5,
                    ProductName="fan",
                    Price=2000,
                    CategoryName="Home Appliance",
                    Manufacturer="Bajaj",
                    ShortCode="fn"
                },
                 new Product
                {
                    ProductId=6,
                    ProductName="Chips",
                    Price=20,
                    CategoryName="Fast Food",
                    Manufacturer="Lays",
                    ShortCode="chip"
                },
                 new Product
                {
                    ProductId=7,
                    ProductName="Samsung A50",
                    Price=20000,
                    CategoryName="Smart Phone",
                    Manufacturer="Samsung",
                    ShortCode="phn"
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
            PriceValidation();
            Console.WriteLine("Enter ShortCode");
            string Sc = ShortCodeOptimization();
           
            Console.WriteLine("Enter Manufacturer");
            string manu = Console.ReadLine();
            ListOfItems.Add(new Product { Price = ProductPrice, ProductId = id, ProductName = name , CategoryName=Cat , Manufacturer=manu  ,  ShortCode = Sc});

        }

        public string ShortCodeOptimization()
        {
            string Sc = Console.ReadLine();
            foreach (Product p in ListOfItems)
            {
                if (Sc == p.ShortCode)
                {
                    Console.WriteLine("Short Code must be unique");
                    ShortCodeOptimization();
                }
            }
            return Sc;
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
                        + p.Price+" Manufacturer : " + p.Manufacturer +" Short Code : " + p.ShortCode);
                }
            }
        }

        public void PriceValidation()
        {
            Console.WriteLine("Enter ProductPrice");
            try
            {
                ProductPrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Price should be a number");
                PriceValidation();
            }


            

        }
    }
}
