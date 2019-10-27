namespace ITVDN_Task_2
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ITVDN_Task_2.Models;

    public class Footall_DB : DbContext
    {
        public Footall_DB()
            : base("name=Footall_DB")
        {
            Database.SetInitializer(new Initializer()); 
        }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> Players { get; set; }
    }

    class Initializer : DropCreateDatabaseAlways<Footall_DB>
    {
        protected override void Seed(Footall_DB context)
        {
            context.Database.ExecuteSqlCommand("ALTER TABLE [Players] NOCHECK CONSTRAINT[FK_dbo.Players_dbo.Teams_TeamId] ");
            context.Database.ExecuteSqlCommand("INSERT INTO Players([Name],[Position],[Age],[TeamId]) VALUES('Lewis Richards','a',39,5),('Moses Bennett','tempus',60,1),('Brody England','consequat',52,1),('Mark Park','natoque',25,1),('Wayne Jackson','enim,',59,1),('Jesse Mayo','erat.',48,4),('Hector Barnes','Curabitur',41,5),('Lane Kemp','semper',67,4),('Oleg Atkinson','mauris',48,5),('Abel Macias','tempor',62,3),('Sylvester Schmidt','non',36,3),('Reese May','elit,',63,2),('Price Jarvis','Suspendisse',30,2),('Keaton Harrell','odio',39,2),('Tanner Richardson','Aliquam',36,2),('Marshall Olson','arcu',66,1),('Nathaniel Hill','ullamcorper,',70,5),('Paki Mcdonald','Nullam',28,5),('Brody Swanson','ligula.',69,3),('Walker Dean','semper',31,2),('Brett England','Curae;',48,4),('Kadeem Franco','Donec',21,3),('Ira Gay','lectus',58,1),('Nash Ball','Nullam',64,5),('Dylan Blevins','Nullam',30,3),('Jason Morgan','dui',58,5),('Drew Waters','dui',23,3),('Ira Hale','scelerisque',34,3),('Ross Merrill','viverra.',66,4),('Fuller Ayala','sem.',55,2),('Byron Pennington','at',50,4),('Abbot Melendez','ut',38,4),('Hyatt Berry','mauris',38,1),('Lucian Peterson','est.',54,4),('Acton Kidd','quam,',47,1),('Jerry Knapp','mauris',30,2),('Uriel Wells','sit',66,2),('Hoyt Perkins','cursus,',49,1),('Camden Phelps','interdum',59,4),('Harper Ellison','dui.',46,2),('Hamilton Monroe','Sed',29,4),('Hayden Holmes','Proin',59,2),('Mannix Howell','in',49,3),('Ivor Parsons','amet,',23,4),('Abel Middleton','velit.',39,2),('Dale Chen','est,',67,2),('Plato Gross','risus.',54,5),('Howard Mullen','morbi',30,4),('Axel Meyers','sed',62,2),('Dale Glenn','lectus',39,1),('Gavin Warren','consectetuer,',50,3),('Dante Miller','diam',62,2),('Silas Monroe','ipsum',40,1),('William Patton','mattis',47,2),('Samuel Snider','ultrices.',40,1),('Castor Pace','Donec',58,5),('Caesar Clemons','nec',34,1),('Kuame Curry','In',42,5),('Kelly Church','vulputate',21,5),('Malik Fox','ultrices,',57,5),('Tanner Estes','turpis',23,1),('Yardley Ewing','tortor.',51,3),('Brandon Sutton','imperdiet',68,4),('Keegan Horn','Suspendisse',39,5),('Steven Wagner','Nunc',65,2),('Castor Mcmillan','quis,',21,5),('Wade Rosa','mauris',51,3),('Fletcher Weaver','Vivamus',63,2),('Deacon Conrad','Aenean',22,3),('Erasmus Browning','vel',36,2),('Byron Bauer','aliquet',61,1),('Palmer Mason','sed',54,4),('Alan Horne','lacus.',49,5),('Luke Cobb','ultrices,',28,2),('Zahir Mcdaniel','rutrum,',42,3),('Curran Castro','auctor',43,4),('Acton Ochoa','arcu.',25,3),('Damian Rogers','massa',34,3),('Malachi Byers','non,',45,5),('Hiram Tanner','Mauris',47,3),('Benjamin Crosby','in',50,3),('Kieran Guerra','amet,',21,2),('Isaiah Boyer','sed',36,2),('Francis Macias','magna,',36,2),('Chase Ortiz','erat.',67,3),('Kamal Sharp','Cras',35,1),('Jonas Abbott','eu',28,4),('Price Macdonald','Lorem',48,2),('Bradley Cobb','dignissim.',42,3),('Leroy Hall','montes,',53,3),('Fletcher Sweeney','Sed',40,3),('Louis Bond','faucibus',50,4),('Lucian Russo','nibh.',62,5),('Calvin Chapman','euismod',55,2),('Raphael Noel','eget',23,3),('Judah Phillips','faucibus',51,1),('Abbot Conrad','Quisque',26,4),('Kieran Bradford','placerat',34,3),('Hasad Bryant','commodo',54,1),('Carter Mccormick','urna,',60,5)");
            context.Database.ExecuteSqlCommand("ALTER TABLE [Players] CHECK CONSTRAINT[FK_dbo.Players_dbo.Teams_TeamId]");
            context.Database.ExecuteSqlCommand("INSERT INTO Teams([Name],[Coach]) VALUES('Ponoka','Tanek Horne'),('South Bend','Vernon Hartman'),('Ham-sur-Sambre','Jerome Valentine'),('Ghlin','Xavier Waters'),('Calgary','Tanner Adams')");

            context.SaveChanges();
        }
    }
}