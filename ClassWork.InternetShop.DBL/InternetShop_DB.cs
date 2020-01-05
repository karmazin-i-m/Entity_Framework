namespace ClassWork.InternetShop.DBL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ClassWork.InternetShop.DBL.Models;
    using ClassWork.InternetShop.DBL.Initializators;
    using ClassWork.InternetShop.DBL.Configurations;

    public class InternetShop_DB : DbContext
    {
        static InternetShop_DB()
        {
            Database.SetInitializer(new InitializerObject());
        }
        public InternetShop_DB()
            : base("name=InternetShop_DB")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInfo> ProductsInfo { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomersBaseConfiguration());
            modelBuilder.Configurations.Add(new OrdersBaseConfiguration());
            modelBuilder.Configurations.Add(new ProductsBaseConfiguration());
            modelBuilder.Configurations.Add(new ProductsInfoBaseConfiguration());

            //modelBuilder.Entity<Product>()
            //    .HasRequired(p => p.ProductInfo)
            //    .WithRequiredPrincipal(p => p.Product);

            //modelBuilder.Entity<Product>()
            //    .HasRequired(p => p.ProductInfo)
            //    .WithRequiredPrincipal(p => p.Product);

            //modelBuilder.Entity<Order>()
            //    .HasMany(o => o.Products)
            //    .WithMany(p => p.Orders)
            //    .Map(m =>
            //    {
            //        m.ToTable("ProductOrder");
            //        m.MapLeftKey("ProductId");
            //        m.MapRightKey("OrderId");
            //    });

            //modelBuilder.Entity<Customer>()
            //    .HasMany(c => c.Orders)
            //    .WithRequired(o => o.Customer);

            base.OnModelCreating(modelBuilder);
        }
    }
}