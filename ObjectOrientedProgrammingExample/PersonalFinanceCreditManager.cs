using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingExample
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit Calculated");
        }

        public void Option()
        {
            throw new NotImplementedException();
        }
    }
}
