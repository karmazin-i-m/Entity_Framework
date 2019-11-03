using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.InternetShop.DBL.Models
{
    public class Customer
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return $"Customer, Id:{this.Id}, Name: {this.Name}, Orders: {this.Orders.Count}";
        }
    }
}
