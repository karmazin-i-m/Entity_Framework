namespace DB_Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    internal class DB_Model : DbContext
    {
        // Your context has been configured to use a 'DB_Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DB_Model.DB_Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DB_Model' 
        // connection string in the application configuration file.
        public DB_Model()
            : base("name=DB_Model")
        {
        }

        static DB_Model()
        {
            Database.SetInitializer<DB_Model>( new Initializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Audience> Audiences { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}