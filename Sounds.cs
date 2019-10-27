using System;
using NAudio.Wave;
using System.Threading;

namespace ClassBreakAlarmClock
{
    public static class Sounds
    {
        static Sounds()
        {

        }

        public static void MusicPlayer()
        {
            using (var audioFile = new AudioFileReader(@"music\bells-tibetan-daniel_simon.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
