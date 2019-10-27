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
            List<string> breakSounds = new List<string>() { @"music\bells-tibetan-daniel_simon.wav", @"music\old-fashioned-school-bell-daniel_simon.wav" };
            List<string> warningSounds = new List<string>() { @"music\front-desk-bells-daniel_simon.wav", @"music\service-bell_daniel_simion.wav" };
            
            string breaksTest = "14:02"; string warningsTest = "14:04";

            List<string> breaks = new List<string>() { "9:30", "11:30", "14:15", "16:00", breaksTest };
            List<string> warnings =new List<string>() { "9:25", "11:25", "14:10", "15:55", warningsTest };


            Alarm.alarm(breaks, breakSounds, ConsoleColor.Green ,warnings,warningSounds,ConsoleColor.Red);
        }

    }
}