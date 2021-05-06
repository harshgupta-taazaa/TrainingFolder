using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace codefirst
{
    public class Product
    {
        public string productId { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public int price { get; set; }

       public Productdetails Productdetails { get; set; }
    }
}
