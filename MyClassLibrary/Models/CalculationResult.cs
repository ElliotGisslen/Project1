using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Models
{
    public class CalculationResult
    {
        public int Id { get; set; }
        public double Input1 { get; set; }
        public double Input2 { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }
        public DateTime Date { get; set; }

    }
}
