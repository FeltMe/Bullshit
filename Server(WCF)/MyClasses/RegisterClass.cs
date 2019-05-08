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
            using (MyAccounst accounst = new MyAccounst())
            {
                try
                {
                    if (accounst.Users.Contains(user) == false)
                    {
                        accounst.Users.Add(user);
                        Console.WriteLine($"User {user.Login} Secureful added");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("User already Exist");
                        return false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine("Eror while adding");
                    return false;
                }
            }
        }
    }
}
