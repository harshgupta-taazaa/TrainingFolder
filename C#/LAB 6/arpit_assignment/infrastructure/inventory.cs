using System;
using core;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace infrastructure
{
    public class inventory
    {
        static ArrayList list = new ArrayList();
        static inventory()
        {
            list.Add(new product
            {
                Title = "ball",
                Price = 200,
                Color = "white",
            });
            list.Add(new product
            {
                Title = "cdf",
                Price = 200,
                Color = "white",
            });
            list.Add(new product
            {
                Title = "bat",
                Price = 200,
                Color = "white",
            });
            list.Add(new product
            {
                Title = "goal",
                Price = 200,
                Color = "white",
            });
            list.Add(new product
            {
                Title = "cat",
                Price = 5000,
                Color = "BLACK"
            });
        }


         public void AddProduct(string title,decimal price,string color)
        {
                list.Add(new product
                {
                    Title = title,
                    Price =price,
                    Color=color,
                }) ;

        }
        public override string ToString()
        {
            string s="";
            foreach (product p in list)
            {
                s += "Title : " + p.Title + " -> Price : " + p.Price + " -> Color : " + p.Color+"\n";
                //Console.WriteLine(s);
                
            }
            return s;


        }
    }
}
