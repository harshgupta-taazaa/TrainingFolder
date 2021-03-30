using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return ($"Id : {Id} Title : {Title} Price : {Price}");
        }
    }

}
