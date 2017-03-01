using System;
using System.Threading;

namespace WindowsService
{
    public class Messenger
    {
        public void WriteCurrentTime()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString());
                Thread.Sleep(1800);
            }
        }
    }
}