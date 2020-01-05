using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.Configurations
{
    class CustomersBaseConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomersBaseConfiguration()
        {
            ToTable("Customers");
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired();
            HasMany(c => c.Orders)
                .WithRequired(o => o.Customer);
        }
    }
}
