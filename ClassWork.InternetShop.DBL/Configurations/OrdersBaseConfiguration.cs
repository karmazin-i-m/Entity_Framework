using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.Configurations
{
    class OrdersBaseConfiguration : EntityTypeConfiguration<Order>
    {
        public OrdersBaseConfiguration()
        {
            ToTable("Orders");
            HasKey(o => o.Id);
            HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .Map(m =>
                {
                    m.ToTable("ProductOrder");
                    m.MapLeftKey("ProductId");
                    m.MapRightKey("OrderId");
                });
        }
    }
}
