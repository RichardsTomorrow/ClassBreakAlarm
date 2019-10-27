/// sounds are thanks to http://soundbible.com/2218-Service-Bell-Help.html, http://soundbible.com/2205-Bells-Tibetan-Large.html, http://soundbible.com/2190-Front-Desk-Bell.html, http://soundbible.com/2185-Old-School-Bell.html

using System;
using System.Threading;
using System.Collections.Generic;

namespace ClassBreakAlarmClock
{
    class Program
    {

        static void Main()
        {
            Alarm();
        }
        static void Alarm()
        {
            List<string> breakAlarms = new List<string>() { @"music\bells-tibetan-daniel_simon.wav", @"music\old-fashioned-school-bell-daniel_simon.wav" };
            List<string> warningAlarms = new List<string>() { @"music\front-desk-bells-daniel_simon.wav", @"music\service-bell_daniel_simion.wav" };

            string breaksTest = "17:34"; string warningsTest = "00:00";

            string[] breaks = { "9:30", "11:30", "14:15", "16:00", breaksTest };
            string[] warnings = { "9:25", "11:25", "14:10", "15:55", warningsTest };

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(DateTime.Now.ToString("H:mm:ss"));
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;

                string buffer = DateTime.Now.ToString("H:mm"); //actual breaks
                foreach (string time in breaks)
                {
                    if (buffer.Contains(time))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It is break time.");

                        Sounds.MusicPlayer(breakAlarms);

                        Thread.Sleep(60000);
                        Console.Clear();
                    }
                }
                foreach (string time in warnings) //warnings
                {
                    if (buffer.Contains(time))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning!! Five minutes until break time.");

                        Sounds.MusicPlayer(warningAlarms);

                        Thread.Sleep(60000);
                        Console.Clear();
                    }
                }
            }


        }
    }
}