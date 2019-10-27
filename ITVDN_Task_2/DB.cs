namespace ITVDN_Task_2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DB : DbContext
    {
        // Your context has been configured to use a 'DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITVDN_Task_2.DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DB' 
        // connection string in the application configuration file.
        public DB()
            : base("name=DB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MyClass1> MyClass1s { get; set; }
        public virtual DbSet<MyClass2> MyClass2s { get; set; }
        public virtual DbSet<MyClass3> MyClass3s { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}