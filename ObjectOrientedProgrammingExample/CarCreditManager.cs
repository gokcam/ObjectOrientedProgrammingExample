using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingExample
{
    class CarCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Car Credit Calculated");
        }

        public void Option()
        {
            throw new NotImplementedException();
        }
    }
}
