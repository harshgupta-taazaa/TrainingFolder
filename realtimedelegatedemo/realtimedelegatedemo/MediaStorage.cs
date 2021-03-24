using System;
using System.Collections.Generic;
using System.Text;

namespace realtimedelegatedemo
{
    public class MediaStorage
    {
        public delegate int PlayerMedia(string a);

        public void ReportResult(PlayerMedia p , string type)
        {
            var status = p(type);
            if (status == 0)
            {
                Console.WriteLine("media played successfully");

            }
            else
            {
                Console.WriteLine("media did not play succesfully");
            }
        }
    }
}
