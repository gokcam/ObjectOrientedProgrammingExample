using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingExample
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Logged");
        }
    }
}
