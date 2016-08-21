using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tick_tack_toe.Models
{
    public class Game
    {
        public int ID { get; set; }
        public Player Winner { get; set; }

        public virtual ICollection<Turn> Turns { get; set; }
    }
}