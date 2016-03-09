using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

using WCFServiceContract;

namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:10002/BaseName/");
            ServiceHost host = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Service is running.");
                Console.WriteLine("Press <ENTER> to quit.");
                Console.WriteLine();
                Console.ReadLine();

                host.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception: {0}", ce.Message);
                host.Abort();
            }

        }
    }
}
