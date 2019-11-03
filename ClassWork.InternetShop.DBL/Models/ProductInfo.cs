using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.InternetShop.DBL.Models
{
    public class ProductInfo
    {
        public Int32 Id { get; set; }
        public Int32 Weight { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            return $"ProductInfo, Id: {this.Id}, Weight: {this.Weight}";
        }
    }
}
