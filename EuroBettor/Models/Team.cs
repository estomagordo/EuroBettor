using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroBettor.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Match> HomeGames { get; set; }
        public ICollection<Match> AwayGames { get; set; }
    }
}
