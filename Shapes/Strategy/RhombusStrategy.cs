using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Strategy
{
    public class RhombusStrategy : IStrategy
    {
        public AreaPerimiter Execute(double a, double b, double c)
        {
            // Denna logik ska göras om för att funka med en triangel!!!
            // Just nu är det för rektangel :)
            var returnValues = new AreaPerimiter();
            returnValues.Perimiter = a * 4;
            //returnValues.Area = Math.Sqrt(returnValues.Perimiter / 2 * ((returnValues.Perimiter / 2 - a) * (returnValues.Perimiter / 2 - b) * (returnValues.Perimiter / 2 - c)));
            returnValues.Area = 0.5 * b * Math.Sqrt((4*a*a)-(b*b));
            return returnValues;
        }
    }
}
