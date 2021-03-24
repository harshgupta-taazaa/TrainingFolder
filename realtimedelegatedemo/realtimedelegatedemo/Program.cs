using System;

namespace realtimedelegatedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MediaStorage m = new MediaStorage();
            AudioPlayer ap = new AudioPlayer();
            VideoPlayer vp = new VideoPlayer();

            MediaStorage.PlayerMedia PlayedDelegate = ap.PlayAudioFile;
            m.ReportResult(PlayedDelegate, "wps");
            

        }
    }
}
