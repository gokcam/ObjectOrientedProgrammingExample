using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingExample
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Credit Calculated");
        }

        public void Option()
        {
            throw new NotImplementedException();
        }
    }
}
