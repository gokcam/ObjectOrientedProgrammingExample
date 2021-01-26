using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingExample
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database Logged");
        }
    }
}
