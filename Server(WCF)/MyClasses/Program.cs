using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server_WCF_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ServiceHost host = new ServiceHost(typeof(WCFRealize));
                host.Open();
                Console.WriteLine("WCF Service Started");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
