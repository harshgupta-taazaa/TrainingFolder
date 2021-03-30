using System;
using System.Collections.Generic;
using System.Text;

namespace deligatesrealtimedemo
{
    public class VideoPlayer
    {
        private int VideoPlayerStatus;
        public int PlayVideoFile(string a)
        {
            if (a == "mp4")
                VideoPlayerStatus = 0;
            else
                VideoPlayerStatus = -1;
            return VideoPlayerStatus;
        }
    }
}
