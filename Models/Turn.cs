using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tick_tack_toe.Models
{
    public enum Player
    {
        Player, Computer
    }
    public class Turn
    {
        [Key, Column(Order = 1)]
        public int GameId { get; set; }
        [Key, Column(Order = 2)]
        public int Number { get; set; }

        public virtual Game Game { get; set; }
    }
}