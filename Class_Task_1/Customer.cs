using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_1
{
    public class Customer
    {
        public int ID { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
            this.Orders = new List<Order>();
        }
    }
}
