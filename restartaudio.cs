using System;
using System.ServiceProcess;

namespace RestartAudio
{
    class RestartAudio
    {
        static void Main()
        {
            ServiceController sc = new ServiceController("audiosrv");

            if (sc.Status == ServiceControllerStatus.Running)
            {
                Console.WriteLine("The {0} service is stopping.", sc.DisplayName);
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                Console.WriteLine("The {0} service was stopped successfully.", sc.DisplayName);
                Console.WriteLine();
            }

            Console.WriteLine("The {0} service is starting.", sc.DisplayName);
            sc.Start();
            sc.WaitForStatus(ServiceControllerStatus.Running);
            Console.WriteLine("The {0} service was started successfully.", sc.DisplayName);
            Console.WriteLine();
        }
    }
}
