namespace ITVDN_AdditionTask_1
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class DB : DbContext
    {
        // Your context has been configured to use a 'DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITVDN_AdditionTask_1.DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DB' 
        // connection string in the application configuration file.
        public DB()
            : base("name=DB")
        {
            Database.SetInitializer<DB>(new Initializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> Players { get; set; }
    }

    internal class Initializer : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {
            Team team1 = new Team() { ID = 1, Name = "Team1" };
            Team team2 = new Team() { ID = 2, Name = "Team2" };
            context.Teams.Add(team1);
            context.Teams.Add(team2);
            context.SaveChanges();

            Player player1 = new Player() { ID = 1, Name = "Xoft", Goals = 200, Team = team1 };
            Player player2 = new Player() { ID = 2, Name = "Qult", Goals = 123, Team = team2 };
            Player player3 = new Player() { ID = 3, Name = "Lamp", Goals = 3465, Team = team1 };

            List<Player> players = new List<Player>() { player1, player2, player3 };

            context.Players.AddRange(players);
            context.SaveChanges();
        }
    }
}
