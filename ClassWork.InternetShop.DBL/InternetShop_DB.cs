namespace ClassWork.InternetShop.DBL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ClassWork.InternetShop.DBL.Models;
    using ClassWork.InternetShop.DBL.Initializators;

    public class InternetShop_DB : DbContext
    {
        public InternetShop_DB()
            : base("name=InternetShop_DB")
        {
            Database.SetInitializer(new InitializerObject());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInfo> ProductsInfo { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductInfo>().ToTable("ProductsInfo");

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.ProductInfo)
                .WithRequiredPrincipal(p => p.Product);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .Map(m =>
                {
                    m.ToTable("ProductOrder");
                    m.MapLeftKey("ProductId");
                    m.MapRightKey("OrderId");
                });

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOptional(o => o.Customer);

            base.OnModelCreating(modelBuilder);
        }
    }


}