using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace codefirst
{
    public class Productdetails
    {
       public string Id { get; set; }
        public string owner { get; set; }

        public string city { get; set; }

        public string ProductId { get; set; }

        [Required]
        public Product Product { get; set; }

    }
}
