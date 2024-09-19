using System.Configuration.Install;
using System.Reflection;
using System;
using System.ServiceProcess;

namespace ComputerBattery
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                    new ComputerBatteryService()
            };
            ServiceBase.Run(ServicesToRun);

            //Console.WriteLine("Start process");

            //if (Environment.UserInteractive)
            //{
            //    Console.WriteLine("Start UserInteractive");

            //    var parameter = string.Concat(args);
            //    switch (parameter)
            //    {
            //        case "--install":
            //            try
            //            {
            //                ManagedInstallerClass.InstallHelper(new[] { Assembly.GetExecutingAssembly().Location });

            //                Console.WriteLine("Successful installed");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine("Exception during installation");
            //                Console.WriteLine(ex.Message);

            //            }
            //            break;
            //        case "--uninstall":
            //            ManagedInstallerClass.InstallHelper(new[] { "/u", Assembly.GetExecutingAssembly().Location });
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Start ServiceBase");

            //    ServiceBase[] ServicesToRun;
            //    ServicesToRun = new ServiceBase[]
            //    {
            //        new ComputerBatteryService()
            //    };
            //    ServiceBase.Run(ServicesToRun);
            //}
        }
    }
}
