using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Models
{

    public class RockPaperScissorsResult
    {
        public int Id { get; set; }
        public string WinOrLoss { get; set; }
        public DateTime Date { get; set; } 
        public string CurrentWinRatio { get; set; }

    }
}
