using System;

namespace WindowsService
{
    internal class Service : IService
    {
        public void Start()
        {
            Console.WriteLine("Start");

            Messenger messanger = new Messenger();
            messanger.WriteCurrentTime();
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}