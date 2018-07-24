using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePOC
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Divide(int num, int denominator);

        [OperationContract(IsOneWay = true)]
        void DoWork();
    }
}
