using System;

namespace deligatesrealtimedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaStorage md = new MediaStorage();
            AudioPlayer ap = new AudioPlayer();
            VideoPlayer vp = new VideoPlayer();
            MediaStorage.PlayerMedia pd = ap.PlayAudioFile;

            md.reportresult(pd, "mp3");
           // Console.WriteLine();
            pd = vp.PlayVideoFile;
            md.reportresult(pd, "mp4");
           // Console.WriteLine();

        }
    }
}
