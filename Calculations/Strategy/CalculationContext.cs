using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Strategy
{
    public class CalculationContext
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public Calculation ExecuteStrategy(double a, double b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
