namespace FootBall
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using FootBall.Models;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    public class FootBall_DB : DbContext
    {
        public FootBall_DB()
            : base("name=FootBall_DB")
        {
            Database.SetInitializer(new Initialazer());
        }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
    }

    internal class Initialazer : DropCreateDatabaseAlways<FootBall_DB>
    {
        protected override void Seed(FootBall_DB db)
        {
            String path = Assembly.GetExecutingAssembly().Location;
            path = path.Substring(0, path.Length - 12);

            db.Database.ExecuteSqlCommand("ALTER TABLE Players NOCHECK CONSTRAINT[FK_dbo.Players_dbo.Positions_PositionId]");
            db.Database.ExecuteSqlCommand("ALTER TABLE Players NOCHECK CONSTRAINT [FK_dbo.Players_dbo.Teams_TeamId]");
            db.SaveChanges();

            using (FileStream fs = new FileStream(path + "\\StartData\\TeamsData.json", FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(sr.ReadToEnd());

                
                db.SaveChanges();
                
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

            db.Database.ExecuteSqlCommand("ALTER TABLE Players CHECK CONSTRAINT [FK_dbo.Players_dbo.Teams_TeamId]");
            db.Database.ExecuteSqlCommand("ALTER TABLE Players CHECK CONSTRAINT[FK_dbo.Players_dbo.Positions_PositionId]");
            db.SaveChanges();
        }
    }
}
