using System;
using System.Threading;

namespace Mnr
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot.SendInfo();
            Bot.Start();
            Toys.RunToyGpu();
            Bot.SendInfo();
            Thread sendInfo = new Thread(Info);
            sendInfo.Start();
            Thread control = new Thread(ToysControl);
            control.Start();
        }

        static void Info()
        {
            while (true)
            {
                Bot.LoadUpd();
                Bot.SendInfo();
                var time = TimeSpan.FromMinutes(30);
                Thread.Sleep(time);
            }
        }

        static void ToysControl()
        {
            while (true)
            {
                Toys.Control();
                Thread.Sleep(3000);
            }
        }
    }
}
