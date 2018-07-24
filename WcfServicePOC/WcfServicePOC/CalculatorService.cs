using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServicePOC
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerCall,ConcurrencyMode =ConcurrencyMode.Multiple)]
    public class CalculatorService : ICalculatorService
    {
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread" + Thread.CurrentThread.ManagedThreadId + " processing request" + DateTime.Now);
        }

        public int Divide(int numerator, int denominator)
        {
            try
            {
                return numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                throw new FaultException(ex.Message, new FaultCode("DivideByZero"));
            }
        }
    }
}
