using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server_WCF_.Intrfase
{
    [ServiceContract]
    public interface IWcfInterface
    {
        [OperationContract]
        void WriteToDbOneUser(object user);
        [OperationContract]
        object ReadFromDbOneUser();
        [OperationContract]
        object RetrunCurentStateOfProject(int ProjectId); // Return to user full state of project + return state of tasks
        [OperationContract]
        bool IsLogined(object user);
    }
}
