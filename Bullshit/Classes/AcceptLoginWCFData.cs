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

        public bool CheckIn(string username, string password, int ProjectId ,ref User user, ref Project project)
        {
            user.Login = /*Enc.Encryption*/username;
            user.Password = /*Enc.Encryption*/password;
            project.Id = ProjectId;

            WcfInterfaceClient client = new WcfInterfaceClient();
            if (client.IsLogined(user, project))
            {
                return true;
            }
            else return false;
        }
    }
}
