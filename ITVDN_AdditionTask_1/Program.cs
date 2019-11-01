using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootBall;
using FootBall.Models;

namespace ITVDN_AdditionTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(FootBall_DB db = new FootBall_DB())
            {
                //'Не удалось привести тип объекта "System.Collections.Generic.List`1[FootBall.Models.Player]" к типу "FootBall.Models.Player".'
                foreach (Player player in db.Players)
                {
                    Console.WriteLine(player);
                }
            }

            Console.ReadLine();
        }
    }
}
