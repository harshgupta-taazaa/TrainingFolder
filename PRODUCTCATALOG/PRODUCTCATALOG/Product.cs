using System;
using System.Collections.Generic;
using System.Text;

namespace PRODUCTCATALOG
{
    public class Product : Category
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int Price { get; set; }
        public string Category { get; set;}

        public string Manufacturer { get; set; }
        
        //public string ProductShortCode { get; set; }

        public override string ToString()
        {
            return " Id : " + ProductId + " Product Name : " + ProductName + " Price : " + Price + " Catogery :"
                + CategoryName+ " Manufacturer :" + Manufacturer;

        }
    }
}
