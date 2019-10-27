using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Task_2.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
