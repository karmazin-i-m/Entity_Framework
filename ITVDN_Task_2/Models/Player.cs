using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public virtual Position Position { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Age: {Age}; Team: {Team.Name}; Position: {Position.PositionName} ";
        }
    }
}
