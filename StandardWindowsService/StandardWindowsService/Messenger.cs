using System;
using System.IO;
using System.Threading;

namespace StandardWindowsService
{
    internal class Messenger
    {
        public void WriteCurrentTime()
        {
            for (int i = 0; i < 10; i++)
            {
                string path = (@"Z:\Dev meeting\TEST.txt");
                File.AppendAllText(path, DateTime.Now.ToShortTimeString());
                Thread.Sleep(1800);
            }
        }
    }
}