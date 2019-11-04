using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL.Interfaces;

namespace ClassWork.InternetShop.DBL.Models
{
    public class Product : IModel
    {
       //[Key]
       //[ForeignKey("ProductInfo")]
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public virtual ProductInfo ProductInfo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Product()
        {
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return $"Продукт, Id: {this.Id}, Name: {this.Name}, ProductInfo: [{this.ProductInfo?.Weight}], Orders: {this.Orders.Count} ";
        }
    }
}
