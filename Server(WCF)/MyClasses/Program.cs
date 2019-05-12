using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Net.Sockets;
using System.Net;

namespace Server_WCF_
{
    class Program
    {
        const int port = 8080;
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFRealize));
            host.Open();
            Console.WriteLine("WCF Service Started");
            TcpListener server = null;

            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            server = new TcpListener(localAddr, port);


            server.Start();

            while (true)
            {
                Console.WriteLine("Start... ");


                TcpClient client = server.AcceptTcpClient();

                Console.WriteLine("Connect client...");


                NetworkStream stream = client.GetStream();

                byte[] data = new byte[256];
                StringBuilder response = new StringBuilder();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                Console.WriteLine(response.ToString());

                stream.Close();

                client.Close();

                host.Close();
            }

        }
    }
}
