using System;
using System.Collections.Generic;
using System.Text;

namespace Eventdelegatedemo
{
    class Inventory
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += InventoryTimeHasChanged;

        }
        public void InventoryTimeHasChanged(object theclock , TimeInfoEventArgs ti)
        {
            Console.WriteLine("Inventory Time :{0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
}
