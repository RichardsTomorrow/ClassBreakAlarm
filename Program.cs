/// sounds are thanks to http://soundbible.com/2218-Service-Bell-Help.html, http://soundbible.com/2205-Bells-Tibetan-Large.html, http://soundbible.com/2190-Front-Desk-Bell.html, http://soundbible.com/2185-Old-School-Bell.html

using System;
using System.Threading;


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



            string morningBreak = "9:30"; string warningMorningBreak = "9:25";
            string lunch = "11:30"; string warningLunch = "11:25";
            string afternoonBreak = "14:15"; string warningAfternoonBreak = "14:10";
            string endOfDay = "16:00"; string warningEndOfDay = "15:55";

            string test1 = "16:32"; string test2 = "00:00";

            string[] breaks = { morningBreak, lunch, afternoonBreak, endOfDay, warningMorningBreak, test1 };
            string[] warnings = { warningMorningBreak, warningLunch, warningAfternoonBreak, warningEndOfDay, warningEndOfDay, test2 };

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

                        Sounds.MusicPlayer();

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

                        Console.Beep();
                        Console.Beep();

                        Thread.Sleep(60000);
                        Console.Clear();
                    }
                }
            }


        }
        //public static void MusicPlayer()
        //{
        //    using(var audioFile = new AudioFileReader(@"music\bells-tibetan-daniel_simon.wav"))
        //    using(var outputDevice = new WaveOutEvent())
        //    {
        //        outputDevice.Init(audioFile);
        //        outputDevice.Play();
        //        while (outputDevice.PlaybackState == PlaybackState.Playing)
        //        {
        //         Thread.Sleep(1000);
        //        }
        //    }
        //}


        //public static void StarWars()
        //{
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(250, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(350, 250);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(250, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(350, 250);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //}
    }
}