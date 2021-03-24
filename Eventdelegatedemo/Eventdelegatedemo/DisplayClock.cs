using System;
using System.Collections.Generic;
using System.Text;

namespace Eventdelegatedemo
{
    public class DisplayClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += TimHasChanged;

        }

        public void TimHasChanged(object theClock , TimeInfoEventArgs ti)
        {
            Console.WriteLine("current Time : {o}:{1}:{2}",
                ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());

               
        }
    }
}
