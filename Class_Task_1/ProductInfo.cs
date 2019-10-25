using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_1
{
    public class ProductInfo
    {
        [Key]
        [ForeignKey("Product")]
        public int ID { get; set; }
        public int Cost { get; set; }
        public string Information { get; set; }
        public Product Product {get;set;}
    }
}
