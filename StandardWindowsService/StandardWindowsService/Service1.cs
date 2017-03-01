using System.ServiceProcess;

namespace StandardWindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Messenger messenger = new Messenger();
            messenger.WriteCurrentTime();
        }

        protected override void OnStop()
        {
        }
    }
}