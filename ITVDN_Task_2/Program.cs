using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITVDN_Task_2.Models;

namespace ITVDN_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Footall_DB db = new Footall_DB())
            {

                var teamPlayer = db.Players.Select(t => t).Where(t => t.Age < 30).ToList<Player>();

                var query = db.Teams.Include("Players");

                foreach (var item in query)
                {
                    Console.WriteLine(item.GetType());
                }

                foreach (var item in teamPlayer.FindAll(p => p.TeamId != 3))
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("End");
                Console.ReadKey();
            }
        }
    }
}
