using System;
using System.Collections.Generic;
using System.Text;

namespace deligatesrealtimedemo
{
    public class AudioPlayer
    {
        private int VideoPlayerStatus;
        public int PlayAudioFile(string a)
        {
            if (a == "mvw")
                VideoPlayerStatus = 0 ;
            else
                VideoPlayerStatus = -1;
            return VideoPlayerStatus;
        }
    }
}
