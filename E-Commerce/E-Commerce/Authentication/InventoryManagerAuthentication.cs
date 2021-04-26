using E_Commerce.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Authentication
{
    class InventoryManagerAuthentication
    {

        public Dictionary<string, string> ManagerDetails = new Dictionary<string, string>()
        {
            {"harsh","123" }
        };
        InventoryManager ManagerLogin = new InventoryManager();

       
        public void ValidatingInventoryManager()
        {
            Console.WriteLine("Enter UserName");
            string CustomerUserName = Console.ReadLine();
            if (ManagerDetails.ContainsKey(CustomerUserName))
            {
                Console.WriteLine("Enter Password");
                string PasswordValidation = Console.ReadLine();
                if (PasswordValidation == ManagerDetails[CustomerUserName])
                {
                    ManagerLogin.DisplayManager();
                }
            }
            else
            {
                Console.WriteLine("Sorry Wrong Details");
            }
            }
    }
}
