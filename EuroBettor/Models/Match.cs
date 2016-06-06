using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroBettor.Models
{
    public class Match
    {
        public int ID { get; set; }
        public DateTime Start { get; set; }
        [InverseProperty("HomeGames")]
        public Team Home { get; set; }
        [InverseProperty("AwayGames")]
        public Team Away { get; set; }
        public ICollection<Goal> Goals { get; set; }
    }
}
