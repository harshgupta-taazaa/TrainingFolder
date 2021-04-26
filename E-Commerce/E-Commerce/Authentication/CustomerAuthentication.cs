using E_Commerce.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Authentication
{
    public class CustomerAuthentication
    {
        public Dictionary<string, string> CustomersDetails = new Dictionary<string, string>()
        {
            {"harsh","123" },
            {"sandeep","1234" },
            {"arpit","12345" },
            {"ritik","123" }
        };
        Customer CustomerLogin = new Customer();

        public void MenuItemAvailable()
        {
            CustomerLogin.CustomerDisplay();
        }
        public void CheckingCustomerAlreadyExists()
        {
            Console.WriteLine("Enter UserName");
            string CustomerUserName = Console.ReadLine();
            if (CustomersDetails.ContainsKey(CustomerUserName))
            {
                Console.WriteLine("Enter Password");
                string PasswordValidation = Console.ReadLine();
                if (PasswordValidation == CustomersDetails[CustomerUserName])
                {
                    MenuItemAvailable();
                }
            }
            else
            {
                Console.WriteLine("No user Exists with this username");
                Console.WriteLine("1- Sign up as a new User");
                Console.WriteLine("2-Exit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    AddCustomer();
                }
                else
                {
                    Console.Clear();
                }
            }

        }
        public void AddCustomer()
        {
            Console.WriteLine("Enter the User name to Sign Up");
            string newusername =Console.ReadLine();
            Console.WriteLine("Enter a Password");
            string Newpassword = Console.ReadLine();
            CustomersDetails.Add(newusername, Newpassword);
            //CheckingCustomerAlreadyExists();
        }
        
    }
}
