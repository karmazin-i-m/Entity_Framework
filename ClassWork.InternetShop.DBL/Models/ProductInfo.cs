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
    public class ProductInfo : IModel
    {
        //[Key]
        public Int32 Id { get; set; }
        public Int32 Weight { get; set; }
        public virtual Product Product { get; set; }
        public override string ToString()
        {
            return $"ProductInfo, Id: {this.Id}, Weight: {this.Weight}, Product: {this.Product?.Name}";
        }
    }
}
