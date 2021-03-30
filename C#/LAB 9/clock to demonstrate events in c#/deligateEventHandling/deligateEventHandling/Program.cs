using System;

namespace deligateEventHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            DisplayClock dc = new DisplayClock();
            dc.subscribe(c);
            Inventory iv = new Inventory();
            iv.subscribe(c);
            c.run();

        }
    }
}
