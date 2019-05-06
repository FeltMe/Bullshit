﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Bullshit.Db;

namespace Server_WCF_.Intrfase
{
    [ServiceContract]
    public interface IWcfInterface
    {
        [OperationContract]
        void WriteToDbOneUser(User User);

        [OperationContract]
        User ReadFromDbOneUser();

        [OperationContract]
        User RetrunCurentStateOfProject(int ProjectId); // Return to user full state of project + return state of tasks

        [OperationContract]
        bool IsLogined(User user);
    }
}
