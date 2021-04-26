using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Entity
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int price { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }



        public override string ToString()
        {
            return "Product Id :" + ProductId +" Product Name :"+ ProductName +" Price : " + price+ " Category : "  + Category +" Quantity : "+ Quantity;
        }
    }
}
