using Bullshit.Db;
using Server_WCF_.Intrfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server_WCF_
{
    public class WCFRealize : IWcfInterface
    {
        public void WriteToDbOneUser(User user) //todo
        { 

        }

        public User ReadFromDbOneUser()
        {
            return null; //todo
        }

        public User RetrunCurentStateOfProject(int IdOfProject)
        {
            return null; //todo
        }

        public bool IsLogined(User user) 
        {
            Sercher sercher = new Sercher();
            if (sercher.Serch(user))
                return true;
            else return false;
        }
    }
}
