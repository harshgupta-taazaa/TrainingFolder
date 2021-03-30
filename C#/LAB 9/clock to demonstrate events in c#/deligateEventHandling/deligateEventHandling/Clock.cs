using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace deligateEventHandling
{
    public class Clock
    {
        private int hour;
        private int sec;
        private int mintue ;
        public delegate void SecondChangeHandler(Object Clock, TimeInfoEventArs timeinfo);
        public event SecondChangeHandler Secchange;

        public void run()
        {
            for(; ; )
            {
                Thread.Sleep(100);
                System.DateTime dt = System.DateTime.Now;
                if(dt.Second !=sec)
                {
                    TimeInfoEventArs timeinfo = new TimeInfoEventArs(dt.Hour, dt.Minute, dt.Second);
                    if(Secchange != null)
                    {
                        Secchange(this, timeinfo);
                    }
                }
                this.sec = dt.Second;
                this.mintue = dt.Minute;
                this.hour = dt.Hour;

            }
            
        }

    }
}
