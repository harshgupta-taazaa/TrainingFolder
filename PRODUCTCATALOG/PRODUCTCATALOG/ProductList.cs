using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class ProductList
    {
        int ProductPrice;
        public static HashSet<Product> ListOfItems = new HashSet<Product>
        {
            new Product
            {
                Price=100,
                ProductName="rubber",
                ProductId=1,
                CategoryName="Stationary",
                Manufacturer="Extramarks",
                ShortCode="rb",
                Description="used for erasing"

            },
            new Product
                {
                    ProductId=2,
                    ProductName="pen",
                    Price=20,
                    CategoryName="Stationary",
                    Manufacturer="Cello",
                    ShortCode="pn",
                     Description="used for writing"
                },
                new Product
                {
                    ProductId=3,
                    ProductName="pencil",
                    Price=10,
                    CategoryName="Stationary",
                    Manufacturer="Natraj",
                    ShortCode="pncl",
                    Description="used for writing"
                },
                 new Product
                {
                    ProductId=4,
                    ProductName="apple",
                    Price=100,
                    CategoryName="fruit",
                    Manufacturer="Rakesh Fruits",
                    ShortCode="ap",
                    Description="used for eating"
                },
                 new Product
                {
                    ProductId=5,
                    ProductName="fan",
                    Price=2000,
                    CategoryName="Home Appliance",
                    Manufacturer="Bajaj",
                    ShortCode="fn",
                    Description="used to get fresh air"
                },
                 new Product
                {
                    ProductId=6,
                    ProductName="Chips",
                    Price=20,
                    CategoryName="Fast Food",
                    Manufacturer="Lays",
                    ShortCode="chip",
                    Description="used for eating"
                },
                 new Product
                {
                    ProductId=7,
                    ProductName="Samsung A50",
                    Price=20000,
                    CategoryName="Smart Phone",
                    Manufacturer="Samsung",
                    ShortCode="phn",
                    Description="used for calling"
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
            Console.WriteLine("Enter Product Description");
            string ProductDescription = Console.ReadLine();

            Console.WriteLine("Enter Manufacturer");
            string manu = Console.ReadLine();
            ListOfItems.Add(new Product { Price = ProductPrice, ProductId = id, ProductName = name , CategoryName=Cat , Manufacturer=manu  ,  ShortCode = Sc , Description = ProductDescription});

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
            Console.WriteLine("\tDelete Item By : ?");
            Console.WriteLine("\t1 - Delete Item By Id");
            Console.WriteLine("\t2 - Delete Item By Name");
            Console.WriteLine("\t3 - Delete Item By ShortCode");
            string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                Console.WriteLine("Enter Product Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                ListOfItems.RemoveWhere(x => x.ProductId == id);
                //ListOfItems.RemoveAt(id - 1);
                ShowItems();
            }
            else if (UserInput == "2")
            {
                Console.WriteLine("Enter Product Name :");
                string Delete = Console.ReadLine();
                ListOfItems.RemoveWhere(x => x.ProductName == Delete);
                ShowItems();
            }
            else if (UserInput == "3")
            {
                Console.WriteLine("Enter ShortCode :");
                string Delete = Console.ReadLine();
                ListOfItems.RemoveWhere(x => x.ShortCode == Delete);
                ShowItems();
            }

        }

        public void SearchProduct()
        {
            Console.WriteLine("Search Product by Product Name Or Product Price ");
            Console.WriteLine("Enter a value");
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
            bool found = false;
            foreach (Product p in ListOfItems)
            {
                if (search.ToLower() == p.ProductName.ToLower() || price <= p.Price)
                {
                    found = true;
                    Console.WriteLine(" Id : " + p.ProductId + " Product Name : " + p.ProductName + " Price : "
                        + p.Price + " Manufacturer : " + p.Manufacturer + " Short Code : " + p.ShortCode + " Description : " + p.Description)
                        ;
                }
            }
            if (!found)
            {
                Console.WriteLine("Item not found");
            }
        }

        public void PriceValidation()
        {
            Console.WriteLine("Enter ProductPrice");
            try
            {
                ProductPrice = Convert.ToInt32(Console.ReadLine());
                if (ProductPrice <= 0)
                {
                    Console.WriteLine("Price Should be greater than 0");
                    PriceValidation();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Price should be a number");
                PriceValidation();
            }
        }
    }
}
