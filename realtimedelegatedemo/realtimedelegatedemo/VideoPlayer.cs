using System;
using System.Collections.Generic;
using System.Text;

namespace realtimedelegatedemo
{
    public class VideoPlayer
    {
        private int count = 0;
        public int PlayVideoFile(string ExtensionType)
        {
            if (ExtensionType != "mp4")
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
