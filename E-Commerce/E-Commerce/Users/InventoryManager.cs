using E_Commerce.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Users
{
    
    public class InventoryManager
    {
        Inventory InventoryUser = new Inventory();
        int IntegerNoValidationForPrice;
        int IntegerNoValidationForQuantity;
        public void DisplayManager()
        {
            Console.WriteLine("\t1 - Update Product ");
            Console.WriteLine("\t2 - Add Product ");
            Console.WriteLine("\t3 - Remove Product");
            Console.WriteLine("\t4 - Back to main");
            string UserInput = Console.ReadLine();
            switch (UserInput.ToLower())
            {
                case "1":
                    UpdateProduct();
                    break;
                case "2":
                    AddProducts();
                    break;
                case "3":
                    RemoveProduct();
                    break;
                default:
                    Console.Clear();
                    break;
            }

        }
        private static int id = 0;

        static int generateId()
        {
            return ++id;
        }

        public void AddProducts()
        {
            Console.WriteLine("Enter Product Name");
            String inputProductName = Console.ReadLine();
            PriceValidation();
            Console.WriteLine("Enter Product Category");
            String CategoryInput = Console.ReadLine();
            QuantityValidation();
            Inventory.ListOfItems.Add(new Products
            {
                ProductId = generateId(),
                    ProductName = inputProductName,
                price = IntegerNoValidationForPrice,
                Category = CategoryInput,
                Quantity = IntegerNoValidationForQuantity
            }
                );
            Console.WriteLine("Product Added!!");
            Inventory.ShowListOfItemsAvailable();
            DisplayManager();
        }
        
        public void UpdateProduct()
        {
            if (Inventory.ListOfItems.Count == 0)
            {
                Console.WriteLine("The List Is Empty");
                DisplayManager();
            }
            else
            {
                Console.WriteLine("\t1 - Update Product Name");
                Console.WriteLine("\t2 - Update Product Price");
                Console.WriteLine("\t3 - Update Product Quantity");
                string Input = Console.ReadLine();
                switch (Input.ToLower())
                {
                    case "1":
                        Console.WriteLine("Enter Product Name you want to update");
                        string UpdateProductName = Console.ReadLine();
                        bool found = false;
                        foreach (Products p in Inventory.ListOfItems)
                        {
                            if (UpdateProductName == p.ProductName)
                            {
                                found = true;
                                Console.WriteLine("Enter Updated Name");
                                string EnterUpdatedName = Console.ReadLine();
                                p.ProductName = EnterUpdatedName;

                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("No Product Found ");
                            DisplayManager();
                        }
                        Inventory.ShowListOfItemsAvailable();
                        break;
                    case "2":
                        Console.WriteLine("Enter Product Name");
                        string ProductName1 = Console.ReadLine();
                        bool Namefound1 = false;
                        foreach (Products p in Inventory.ListOfItems)
                        {
                            if (ProductName1 == p.ProductName)
                            {
                                found = true;
                                PriceValidation();
                                p.price = IntegerNoValidationForPrice;
                                Inventory.ShowListOfItemsAvailable();
                            }
                        }
                        if (!Namefound1)
                        {
                            Console.WriteLine("No Product Found ");

                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter Product Name");
                        string ProductName = Console.ReadLine();
                        bool Namefound = false;
                        foreach (Products p in Inventory.ListOfItems)
                        {
                            if (ProductName == p.ProductName)
                            {
                                found = true;
                                QuantityValidation();
                                p.Quantity = IntegerNoValidationForQuantity;
                                Inventory.ShowListOfItemsAvailable();
                            }
                        }
                        if (!Namefound)
                        {
                            Console.WriteLine("No Product Found ");
                            DisplayManager();
                        }
                        break;
                }
            }
            DisplayManager();
        }
        public void RemoveProduct()
        {
            Inventory.ShowListOfItemsAvailable();
            Console.WriteLine("\t1- Delete By Name");
            Console.WriteLine("\t2 - Delete By Id");
            string input = Console.ReadLine();
            if (input == "1")
            {
                string RemoveByProductName = Console.ReadLine();
                Inventory.ListOfItems.RemoveWhere(item => item.ProductName == RemoveByProductName);
                Inventory.ShowListOfItemsAvailable();
               
            }
            else if(input == "2")
            {
                int RemoveByProductId = Int32.Parse(Console.ReadLine());
                Inventory.ListOfItems.RemoveWhere(item => item.ProductId == RemoveByProductId);
                Inventory.ShowListOfItemsAvailable();
            }
            DisplayManager();

        }
        public void PriceValidation()
        {
            Console.WriteLine("Enter Product Price");
            try
            {
                 IntegerNoValidationForPrice = Convert.ToInt32(Console.ReadLine());
                if (IntegerNoValidationForPrice <= 0)
                {
                    Console.WriteLine("Number Should be greater than 0");
                    PriceValidation();
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a valid Number");
                PriceValidation();
                
            }
 
        }

        public void QuantityValidation()
        {
            Console.WriteLine("Enter Quantity Available");
            try
            {
                IntegerNoValidationForQuantity = Convert.ToInt32(Console.ReadLine());
                if (IntegerNoValidationForQuantity <= 0)
                {
                    Console.WriteLine("Number Should be greater than 0");
                    QuantityValidation();

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a valid Number");
                QuantityValidation();

            }

        }
    }
}
