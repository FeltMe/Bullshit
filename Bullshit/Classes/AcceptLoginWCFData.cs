using Bullshit.Db;
using Bullshit.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit.Classes
{
    public class AcceptLoginWCFData
    {
        public int Key { get; set; } = 1;

        public bool CheckIn(string username, string password)
        {
            User loginer = new User()
            {
                Login = Encryption(username, Key),
                Password = Encryption(password, Key)
            };

            WcfInterfaceClient client = new WcfInterfaceClient();
            if (client.IsLogined(loginer))
            {
                return true;
            }
            else return false;
        }

        private string Encryption(string data, int key) //Encryption password
        {
            string newdata = "";
            foreach (char ch in data.ToCharArray())
            {
                char tmp = (char)(ch ^ key);
                newdata += tmp;
            }
            return newdata;
        }
    }
}
