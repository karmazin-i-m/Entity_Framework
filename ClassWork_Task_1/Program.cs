using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Model;


namespace ClassWork_Task_1
{
    class Program
    {
        private static readonly CRUD_Audience crud = new CRUD_Audience();

        static void Main(string[] args)
        {
            Console.WriteLine("ReadAll");
            Show();

            Console.WriteLine("UpDate");
            crud.UpDate(2);
            Show();

            Console.WriteLine("Create");
            Audience audience = new Audience() { Area = 666, Name = "new", NumberSeats = 999 };
            crud.Create(audience);
            Show();

            Console.WriteLine("Read");
            Console.WriteLine(crud.Read(4).Name);
            Console.WriteLine(new String('-', 80));

            Console.WriteLine("Delete");
            crud.Delete(1);
            Show();

            Console.ReadKey();
        }

        private static void Show()
        {
            Console.WriteLine(new string('-', 80));
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(new string('-', 80));
        }
    }
}
