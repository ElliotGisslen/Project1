using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Strategy
{
    public class AdditionStrategy : IStrategy
    {
        public Calculation Execute(double a, double b)
        {
            var returnValues = new Calculation();
            returnValues.CalculationOutcome = a + b;

            return returnValues;

        }
    }
}
