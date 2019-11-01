using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall.Models
{
    public class Position
    {
        [Key]
        public Int32 Id { get; set; }
        public String PositionName { get; set; }
        public ICollection<Player> Players { get; set; }

        public Position()
        {
            this.Players = new List<Player>();
        }
    }
}
