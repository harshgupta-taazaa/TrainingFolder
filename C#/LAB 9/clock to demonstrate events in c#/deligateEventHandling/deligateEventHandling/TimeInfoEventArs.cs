using System;
using System.Collections.Generic;
using System.Text;

namespace deligateEventHandling
{
    public class TimeInfoEventArs:EventArgs
    {
        public int second;
        public int minute;
        public int hour;

        public TimeInfoEventArs(int h,int m,int s)
        {
            this.hour = h;
            this.second= s;
            this.minute = m;
        }

    }
}
