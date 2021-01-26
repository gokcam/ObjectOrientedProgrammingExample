using System;
using System.Collections.Generic;

namespace ObjectOrientedProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultManager consultManager = new ConsultManager();
            consultManager.ToApply(new CarCreditManager(), new List<ILoggerService>() {new SmsLoggerService(), new DatabaseLoggerService() });
            
        }
    }
}
