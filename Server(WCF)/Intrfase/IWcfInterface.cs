using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_WCF_.Intrfase
{
    public interface IWcfInterface
    {
        void WriteToDbOneUser(object user);
        object ReadFromDbOneUser();
        object RetrunCurentStateOfProject(int ProjectId); // Return to user full state of project + return state of tasks
    }
}
