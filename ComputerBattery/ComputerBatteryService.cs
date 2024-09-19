using System.Diagnostics;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ComputerBattery
{
    public partial class ComputerBatteryService : ServiceBase
    {
        private const string eventLogSource = "ComputerBattery";
        private const string eventLogName = "Application";

        public ComputerBatteryService()
        {
            InitializeComponent();

            eventLog = new EventLog();

            if (!EventLog.SourceExists(eventLogSource))
            {
                EventLog.CreateEventSource(eventLogSource, eventLogName);
            }

            eventLog.Source = eventLogSource;
            eventLog.Log = eventLogName;
        }

        protected override void OnStart(string[] args)
        {
            eventLog.WriteEntry("Cuputer battery start");
        }

        protected override void OnStop()
        {
            eventLog.WriteEntry("Cuputer battery stop");
        }

        private void ComputerBaterryElapsed(object sender, System.EventArgs e)
        {
            string batteryPercentage = $"{SystemInformation.PowerStatus.BatteryFullLifetime * 100}";
            eventLog.WriteEntry($"{batteryPercentage}%");
        }
    }
}
