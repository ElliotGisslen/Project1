using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Strategy
{
    public interface IStrategy
    {
        Calculation Execute(double a, double b);
    }
}
