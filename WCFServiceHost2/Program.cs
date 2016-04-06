using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

using WCFServiceContract2;

namespace WCFServiceHost2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:10008/RSI-WCF2/");
            ServiceHost host = new ServiceHost(typeof(DataService2), baseAddress);

            try
            {
                host.AddServiceEndpoint(typeof(IData2), new WSHttpBinding(), "DataService2");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Service2 is running.");
                Console.WriteLine("Press <ENTER> to quit.");
                Console.WriteLine();
                Console.ReadLine();

                //host.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception: {0}", ce.Message);
                host.Abort();
            }

        }
    }
}
