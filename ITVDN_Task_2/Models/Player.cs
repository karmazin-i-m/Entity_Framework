using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Task_2.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Age: {Age}: Team: {Team.Name} ";
        }
    }
}
