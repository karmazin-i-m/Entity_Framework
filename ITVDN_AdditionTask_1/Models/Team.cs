using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_AdditionTask_1.Models
{
    public class Team
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }

        public ICollection<Player> Players  { get; set; }

        public Team()
        {
            Players = new List<Player>(); 
        }
    }
}
