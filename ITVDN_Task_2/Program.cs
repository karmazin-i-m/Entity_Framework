using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ITVDN_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Football_DB db = new Football_DB();
            //F:\Учеба\1A_Курсы_программирования\ПРАКТИКА\EF_Lesson_4\ITVDN_Task_2\bin\Debug\ITVD\StartData\TeamsData.json
            foreach (Player player in db.Players)
            {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }
}
