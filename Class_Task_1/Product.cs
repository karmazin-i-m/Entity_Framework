using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_1
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductInfoID { get; set; }
        public ProductInfo ProductInfo { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Product()
        {
            this.Orders = new List<Order>();
        }
    }
}
