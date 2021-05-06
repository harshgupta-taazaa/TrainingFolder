using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace codefirst
{
    public class Employee
    {
        public string EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        public string productid { get; set; }

       public Product product { get; set; }

    }
}
