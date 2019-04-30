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
        public void WriteToDbOneUser(object user) //todo
        {

        }

        public object ReadFromDbOneUser()
        {
            return null; //todo
        }

        public object RetrunCurentStateOfProject(int IdOfProject)
        {
            return null; //todo
        }

        public bool IsLogined(object user) 
        {
            Sercher sercher = new Sercher();
            var MyUser = (user as User);
            if (sercher.Serch(user))
                return true;
            else return false;
        }
    }
}
