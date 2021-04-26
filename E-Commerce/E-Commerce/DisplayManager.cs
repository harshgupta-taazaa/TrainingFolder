using E_Commerce.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    public class DisplayManager
    {
        CustomerAuthentication CustomerLogin = new CustomerAuthentication();
        InventoryManagerAuthentication InventoryLogin = new InventoryManagerAuthentication();

        public void Display()
        {
            Console.WriteLine("1 - Login As Customer");
            Console.WriteLine("2 - Login As Manager");
            Console.WriteLine("3 - Exit App");
            string UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                CustomerLogin.CheckingCustomerAlreadyExists();
                Display();

                
            }
            else if (UserInput == "2")
            {
                InventoryLogin.ValidatingInventoryManager();
                Display();

            }
            else
            {
                Console.Clear();
            }
        }
        //

            //InventoryLogin.ValidatingInventoryManager();
    }
}
