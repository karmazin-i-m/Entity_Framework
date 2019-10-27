using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITVDN_AdditionTask_1.Models;

namespace ITVDN_AdditionTask_1
{
    class Program : IDisposable
    {
        private static readonly DB db = new DB();
        static void Main(string[] args)
        {
            Console.WriteLine("First() / FirstOrDefault()");
            ShowPlayer(db.Players.First());

            Console.WriteLine("OrderBy()");
            foreach (Player item in db.Players.OrderByDescending(t => t.Goals))
            {
                ShowPlayer(item);
            }

            Console.WriteLine("Count");
            Console.WriteLine(db.Teams.Count<Team>());

            Console.WriteLine("Min");
            Console.WriteLine(db.Players.Min<Player>(t => t.Goals));

            Console.WriteLine("Max");
            Console.WriteLine(db.Players.Max<Player>(t => t.Goals));

            Console.WriteLine("Average");
            Console.WriteLine(db.Players.Average<Player>(t => t.Goals));

            Console.ReadKey();
            //OrderBy(), Count() , Min(), Max() и Average().
        }

        private static void ShowPlayer(Player player)
        {
            Console.WriteLine($"Игрок {player.Name}, имеет ИД {player.ID} и играет в команде {player.Team.Name}, забито голов {player.Goals}");
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
