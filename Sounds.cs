using System;
using NAudio.Wave;
using System.Threading;
using System.Collections.Generic;

namespace ClassBreakAlarmClock
{
    public class Sounds
    {
        static Sounds()
        {

        }

        public static string Selector(List<string> source)
        {
            Random number = new Random();
            return source[number.Next(0,source.Count)];

        }
        public static void MusicPlayer(List<string> soundSet)
        {
            string file = Selector(soundSet);

            using (var audioFile = new AudioFileReader(file))
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
