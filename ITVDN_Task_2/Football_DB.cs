
namespace ITVDN_Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Models;
    using Newtonsoft.Json;

    public class Football_DB : DbContext
    {
        // Your context has been configured to use a 'Football_DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITVDN_Task_2.Football_DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Football_DB' 
        // connection string in the application configuration file.
        public Football_DB()
            : base("name=Football_DB")
        {
            Database.SetInitializer(new Initialazer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Player_Table");
            modelBuilder.Entity<Player>().HasKey(p => p.Id);
            modelBuilder.Entity<Player>().Property(p => p.Name).HasColumnName("Full Name");
            modelBuilder.Entity<Player>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<Team>()
                .HasMany(p => p.Players)
                .WithRequired(p => p.Team)
                .HasForeignKey(p => p.TeamId);

            modelBuilder.Entity<Position>()
                .HasMany(p => p.Players)
                .WithRequired(p => p.Position)
                .HasForeignKey(p => p.PositionId);


            base.OnModelCreating(modelBuilder);
        }
    }

    internal class Initialazer : DropCreateDatabaseAlways<Football_DB>
    {
        protected override void Seed(Football_DB db)
        {
            String path = Assembly.GetExecutingAssembly().Location;
            path = path.Substring(0, path.Length - 17);

            db.Database.ExecuteSqlCommand("ALTER TABLE [Player_Table] NOCHECK CONSTRAINT[FK_dbo.Player_Table_dbo.Positions_PositionId]");
            db.Database.ExecuteSqlCommand("ALTER TABLE [Player_Table] NOCHECK CONSTRAINT [FK_dbo.Player_Table_dbo.Teams_TeamId]");
            db.SaveChanges();

            using (FileStream fs = new FileStream(path + "\\StartData\\TeamsData.json", FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(sr.ReadToEnd()); 

                db.Teams.AddRange(teams);
                db.SaveChanges();


            }

            using (FileStream fs = new FileStream(path + "\\StartData\\PlayersData.json", FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                List<Player> players = JsonConvert.DeserializeObject<List<Player>>(sr.ReadToEnd());

                db.Players.AddRange(players);
                db.SaveChanges();
            }

            Position position1 = new Position() { Id = 1, PositionName = "Нападающий" };
            Position position2 = new Position() { Id = 2, PositionName = "Защитник" };
            Position position3 = new Position() { Id = 3, PositionName = "Вратарь" };
            Position position4 = new Position() { Id = 4, PositionName = "Левый полузащитник" };
            Position position5 = new Position() { Id = 5, PositionName = "Правый полузащитник" };


            db.Positions.AddRange(new List<Position>() { position1, position2, position3, position4, position5 });
            db.SaveChanges();

            db.Database.ExecuteSqlCommand("ALTER TABLE [Player_Table] CHECK CONSTRAINT[FK_dbo.Player_Table_dbo.Positions_PositionId]");
            db.Database.ExecuteSqlCommand("ALTER TABLE [Player_Table] CHECK CONSTRAINT [FK_dbo.Player_Table_dbo.Teams_TeamId]");
            db.SaveChanges();
        }
    }
}