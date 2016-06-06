using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroBettor.Models
{
    public class Goal
    {
        public int ID { get; set; }
        public Match Match { get; set; }
        public TimeSpan Time { get; set; }
        public Player Player { get; set; }
    }
}
