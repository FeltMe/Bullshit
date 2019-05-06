using Bullshit.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_WCF_
{
    public class Sercher
    {
        public bool Serch(object user)
        {
            var MyUser = (user as User);
            using (MyAccounst accounst = new MyAccounst())
            {
                foreach (var item in accounst.Users)
                {
                    if (item.Login == MyUser.Login && item.Password == MyUser.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
