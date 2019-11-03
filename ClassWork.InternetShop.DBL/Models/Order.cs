using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.InternetShop.DBL.Models
{
    public class Order
    {
        public Int32 Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return $"Order, Id: {this.Id}, Customer: [{Customer}], Products: {Products.Count}";
        }
    }
}
