using System;

namespace codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (Foocontext context=new Foocontext())
            {
                Product p = new Product
                {
                    productId = "1",
                    Title = "pen",
                    price=189

                };

                //Employee e = new Employee
                //{
                //    EmployeeId = "2",
                //    Name = "sandeep"
                //};

                Product p1 = new Product
                {
                    productId = "2",
                    Title = "pencil",
                    price = 189

                };
                //context.Products.Add(p1);

                Productdetails p2 = new Productdetails
                {
                    Id="2",
                    owner="sandeep",
                    city="jaipur",
                    Product=p1,
                };
              
                
                //context.Productdetails.Add(p2);



                try
                {
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);

                }
             


            }
            

            
        }
    }
}
