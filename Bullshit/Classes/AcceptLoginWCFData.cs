using Bullshit.Db;
using Bullshit.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Bullshit.Classes;

namespace Bullshit.Classes
{
    public class AcceptLoginWCFData
    {
        public MyEncipher Enc { get; set; } = new MyEncipher();

        public bool CheckIn(string username, string password)
        {
           ServiceReference1.User loginer = new ServiceReference1.User()
           {
               Login = Enc.Encryption(username),
               Password = Enc.Encryption(password)
           };
        
            WcfInterfaceClient client = new WcfInterfaceClient();
            if (client.IsLogined(loginer))
            {
                return true;
            }
            else return false;
        }
    }
}
