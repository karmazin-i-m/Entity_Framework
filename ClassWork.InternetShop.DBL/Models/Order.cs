using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL.Interfaces;

namespace ClassWork.InternetShop.DBL.Models
{
    public class Order: IModel 
    {
        public Int32 Id { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Customer Customer { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return $"Order, Id: {this.Id}, Customer: [{Customer.Name}], Products: {Products.Count}";
        }
    }
}
