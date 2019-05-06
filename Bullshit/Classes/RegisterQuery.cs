using Bullshit.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bullshit.Classes
{
    public class RegisterQuery
    {
        public MyEncipher Enc { get; set; } = new MyEncipher();

        public void AddNewUser(string username, string password, bool role = false)
        {
            WcfInterfaceClient wcf = new WcfInterfaceClient();
            try
            {
                wcf.WriteToDbOneUser(new ServiceReference1.User() { Login = Enc.Encryption(username), Password = Enc.Encryption(password), Right = role });
            }
            catch (Exception)
            {
               MessageBox.Show("Eror while registration");
            }
        }
    }
}
