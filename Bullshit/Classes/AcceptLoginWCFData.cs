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
        public User LoginedUser { get; set; }

        public bool CheckIn(string username, string password, ref User user)
        {
            user.Login = /*Enc.Encryption*/username;
            user.Password = /*Enc.Encryption*/password;

            WcfInterfaceClient client = new WcfInterfaceClient();
            if (client.IsLogined(user))
            {
                return true;
            }
            else return false;
        }
    }
}
