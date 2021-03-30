using System;

namespace polystringoverload
{
    class Program
    {
        public static void Main(string[] args)
        {

            person obj = new person();
            obj.InsertUserDetails("arpit", 22);
            obj.ToString();
          
        }
    }
}
