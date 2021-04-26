using E_Commerce.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Users
{
    public class Customer
    {
        public void CustomerDisplay()
        {
            Console.WriteLine("1 - Menu ");
            string Inputstring = Console.ReadLine();
            if (Inputstring == "1")
            {
                if (Inventory.ListOfItems.Count == 0)
                {
                   
                    Console.Clear();
                    Console.WriteLine("The List is empty, Login as manager and enter some products");
                }
                else
                {
                    BuyProduct();
                }
            }
        }
        public void BuyProduct()
        {
            Inventory.ShowListOfItemsAvailable();
            Console.WriteLine("1 - Add Products");
     
            Console.WriteLine("2 - Back to main");

            Console.WriteLine("3 - CheckOut");

            string UserInput = Console.ReadLine();
            
             if (UserInput == "1")
            {
                Console.WriteLine("Enter Product Name To add");
                string input = Console.ReadLine();
                bool found = false;
                foreach (Products p in Inventory.ListOfItems)
                {
                    if (p.ProductName == input)
                    {
                        found = true;
                        Console.WriteLine("Enter Quantity");
                        int EnterQuantity = Int32.Parse(Console.ReadLine());
                        if (p.Quantity == 0)
                        {
                            Console.WriteLine("This product is not availabe");
                            Console.WriteLine("1 -Try again");
                            Console.WriteLine("2 - Proceed to CheckOut");
                            if (Console.ReadLine() == "1")
                            {
                                BuyProduct();
                            }
                            else
                            {
                                Checkout();
                            }
                        }
                        else if (EnterQuantity > p.Quantity)
                        {
                            Console.WriteLine("Sorry the quantity Exceeds");
                            Console.WriteLine("1 - Try again?");
                            Console.WriteLine("2 - Go Back");
                            if (Console.ReadLine() == "1")
                            {
                                BuyProduct();
                            }
                            else
                            {
                                break;
                            }


                        }
                        else
                        {
                            p.Quantity = p.Quantity - EnterQuantity;
                            Inventory.OrderList.Add(new Products
                            {
                                ProductId = p.ProductId,
                                ProductName = p.ProductName,
                                price = p.price,
                                Category = p.Category,
                                Quantity = EnterQuantity
                            });

                            Console.WriteLine("Product Added !");
                            Console.WriteLine("1-Add More Products ");
                            Console.WriteLine("2-Proceed to checkout");
                            Console.WriteLine("3 - Go Back");
                            String userInput = Console.ReadLine();
                            if (userInput == "1")
                            {
                                BuyProduct();
                            }
                            else if (userInput == "2")
                            {
                                Checkout();
                            }
                            else
                            {
                                foreach (Products item in Inventory.OrderList)
                                {
                                    foreach (Products q in Inventory.ListOfItems)
                                    {
                                        if (item.ProductName == q.ProductName)
                                        {
                                            p.Quantity = q.Quantity + item.Quantity;
                                        }
                                    }
                                }
                                Inventory.OrderList.Clear();
                                Console.Clear();
                            }
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No items found");
                    BuyProduct();
                }
            }
            else if (UserInput == "3")
            {
                Checkout();
            }
            else
            {
                foreach (Products item in Inventory.OrderList)
                {
                    foreach (Products p in Inventory.ListOfItems)
                    {
                        if (item.ProductName == p.ProductName)
                        {
                            p.Quantity = p.Quantity + item.Quantity;
                        }
                    }
                }
                Inventory.OrderList.Clear();
                Console.Clear();
            }
       }
    

        public void Checkout()
            {
            if (Inventory.OrderList.Count == 0)
            {
                Console.WriteLine("The List is Empty");
                Console.WriteLine("1 - Add Products ");
                Console.WriteLine("2 - Back");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    BuyProduct();
                }
                else
                {
                    Console.Clear();
                }

            }
            else
            {
                Console.Clear();
                int totalprice = 0;
                foreach (Products p in Inventory.OrderList)
                {
                    Console.WriteLine(p);
                    totalprice += (p.price * p.Quantity);
                }
                Console.WriteLine("\tTotal Amount to pay");
                Console.WriteLine(totalprice);
                Inventory.OrderList.Clear();
            }
        }
    }
}
