using System;

namespace Eventdelegatedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(c);
            Inventory Inv = new Inventory();
            Inv.Subscribe(c);
            c.Run();

        }
    }
}
