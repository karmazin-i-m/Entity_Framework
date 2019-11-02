using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public ICollection<Player> Players { get; set; }

        public Team()
        {
            this.Players = new List<Player>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
