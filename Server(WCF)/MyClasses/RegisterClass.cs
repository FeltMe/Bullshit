using Bullshit.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Server_WCF_.MyClasses
{
    public class RegisterClass
    {
        public bool AddNewUser(User user)
        {
            MyAccounst myAccounst = new MyAccounst();
            try
            {
                if (myAccounst.Users.ToList().Contains(user) == true)
                {
                    return false;
                }
                else
                {
                    myAccounst.Users.Add(user);
                    myAccounst.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

    }

}
