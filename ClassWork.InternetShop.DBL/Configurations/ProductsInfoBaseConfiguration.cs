using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.Configurations
{
    class ProductsInfoBaseConfiguration : EntityTypeConfiguration<ProductInfo>
    {
        public ProductsInfoBaseConfiguration()
        {
            ToTable("ProductsInfo");
            HasKey(p => p.Id);
            Property(p => p.Weight).IsRequired();
        }
    }
}
