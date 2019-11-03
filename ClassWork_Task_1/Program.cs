using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (InternetShop_DB db = new InternetShop_DB())
            {
                foreach(Product product in db.Products)
                {
                    Console.WriteLine(product);
                }
            }
            Console.ReadLine();
        }
    }
}
