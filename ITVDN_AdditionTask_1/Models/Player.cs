using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_AdditionTask_1.Models
{
    public class Player
    {
        [Key]
        public Int32 ID { get; set; }

        public String Name { get; set; }
        public Int32 Goals { get; set; }

        public virtual Team Team { get; set; } 
    }
}
