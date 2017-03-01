using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WindowsService
{
    public class Configuration
    {
        public static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<IService>(service =>
                {
                    service.ConstructUsing(s => new Service());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });

                configure.RunAsLocalSystem();
                configure.SetServiceName("MyService");
                configure.SetDisplayName("MyService");
                configure.SetDescription("MyService");
            });
        }
    }
}