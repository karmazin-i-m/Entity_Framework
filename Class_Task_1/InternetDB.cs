namespace Class_Task_1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InternetDB : DbContext
    {
        // Your context has been configured to use a 'InternetDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Class_Task_1.InternetDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InternetDB' 
        // connection string in the application configuration file.
        public InternetDB()
            : base("name=InternetDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ProductInfo> ProductsInfo { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}