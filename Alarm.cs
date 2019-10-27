using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassBreakAlarmClock
{ 
    class Alarm
    {

        static Alarm()
        {

        }

        public static void watcher(List<string> times, List<string> sounds, ConsoleColor color)
        {

            string buffer = DateTime.Now.ToString("H:mm"); //actual breaks
            foreach (string time in times)
            {
                if (buffer.Contains(time))
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine("It is break time.");

                    Sounds.MusicPlayer(sounds);

                    Thread.Sleep(60000);
                    Console.Clear();
                }
            }
        }


        public static void alarm(List<string> breakTimes, List<string> breakSounds, ConsoleColor breakColor, List<string> warningTimes, List<string> warningSounds, ConsoleColor warningColor)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(DateTime.Now.ToString("H:mm:ss"));
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;

                watcher(breakTimes, breakSounds, breakColor);
                watcher(warningTimes, warningSounds, warningColor);

            }


        }
    }
}
