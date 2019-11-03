using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.InternetShop.DBL.Models
{
    public class Product
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public ProductInfo ProductInfo { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Product()
        {
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return $"Продукт, Id: {this.Id}, Name: {this.Name}, ProductInfo: [{this.ProductInfo}], Orders: {this.Orders.Count} ";
        }
    }
}
