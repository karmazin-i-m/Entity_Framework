using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_1
{
    public class Order
    {
        public int ID { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            this.Products = new List<Product>();
        }
    }
}
