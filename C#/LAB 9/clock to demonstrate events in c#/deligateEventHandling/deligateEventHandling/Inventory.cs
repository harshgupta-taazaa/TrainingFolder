using System;
using System.Collections.Generic;
using System.Text;

namespace deligateEventHandling
{
    class Inventory
    {
        public void subscribe(Clock tc)
        {
            tc.Secchange += (InventoryTimeHasChanged);
        }

        public void InventoryTimeHasChanged(object Theclock, TimeInfoEventArs ti)
        {
            Console.WriteLine("current inventory time : {0}:{1}:{2}", ti.hour.ToString(),ti.minute.ToString(),ti.second.ToString());
        }
}
}
