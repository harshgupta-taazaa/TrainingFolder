using System;
using System.Collections.Generic;
using System.Text;

namespace deligatesrealtimedemo
{
    public class MediaStorage
    {
        public delegate int PlayerMedia(string a);

        public void reportresult(PlayerMedia p, string a)
        {
            var status = p(a);
            if (status == 0)
                Console.WriteLine("Media Player Succesfully");
            else
                Console.WriteLine("Media did not Player Succesfully");
        }
    }
}
