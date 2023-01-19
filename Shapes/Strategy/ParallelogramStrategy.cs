using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Strategy
{
    public class ParallelogramStrategy : IStrategy
    {
        public AreaPerimiter Execute(double a, double b, double c)
        {
            // Denna logik ska göras om för att funka med en triangel!!!
            // Just nu är det för rektangel :)
            var returnValues = new AreaPerimiter();
            returnValues.Perimiter = a * 2 + b * 2;
            //returnValues.Area = Math.Sqrt(returnValues.Perimiter / 2 * ((returnValues.Perimiter / 2 - a) * (returnValues.Perimiter / 2 - b) * (returnValues.Perimiter / 2 - c)));
            returnValues.Area = b * c;
            return returnValues;
        }

    }
}
