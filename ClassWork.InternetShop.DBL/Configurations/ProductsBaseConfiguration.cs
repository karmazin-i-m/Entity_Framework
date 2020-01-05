using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.Configurations
{
    class ProductsBaseConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductsBaseConfiguration()
        {
            ToTable("Products");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired();
            HasRequired(p => p.ProductInfo).WithRequiredPrincipal(p => p.Product);
        }
    }
}
