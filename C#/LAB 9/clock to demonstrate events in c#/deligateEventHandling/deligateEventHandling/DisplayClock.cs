using System;
using System.Collections.Generic;
using System.Text;

namespace deligateEventHandling
{
    public class DisplayClock
    {
        public void subscribe(Clock tc)
        {
            tc.Secchange += TimeHasChanged;
        }
        
        public void TimeHasChanged(object Theclock,TimeInfoEventArs ti )
        {
            Console.WriteLine( "current time : {0}:{1}:{2}",ti.hour.ToString(),ti.minute.ToString(),ti.second.ToString());
        }
    }

}


