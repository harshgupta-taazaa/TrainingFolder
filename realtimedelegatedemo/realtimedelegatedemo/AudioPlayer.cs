//using System;
using System.Collections.Generic;
using System.Text;

namespace realtimedelegatedemo
{
    public class AudioPlayer
    {
        private int  count =0;
        public int PlayAudioFile(string ExtensionType)
        {
            if (ExtensionType != "wps")
            {
                count = -1;
            }
            else
            {
                count = 0;
            }
            return count;
        }

    }
}
