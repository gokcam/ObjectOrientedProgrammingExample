using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingExample
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File Logged");
        }
    }
}
