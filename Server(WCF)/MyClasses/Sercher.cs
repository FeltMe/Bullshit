using Bullshit.Db;
using Server_WCF_.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_WCF_
{
    public class Sercher
    {
        public bool Serch(User user, Project project)
        {
            using (MyAccounst accounst = new MyAccounst())
            {
                foreach (var item in accounst.Users)
                {
                    if (item.Login == user.Login
                        && item.Password == user.Password
                        && item.CurrentProject.Id == project.Id)

                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
