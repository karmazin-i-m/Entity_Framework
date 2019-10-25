using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 db = new Model1();

            db.Dogs.Add(new Dog() { ID = 1, Name = "Barsik1" });
            db.Dogs.Add(new Dog() { ID = 2, Name = "Barsik2" });
            db.Dogs.Add(new Dog() { ID = 3, Name = "Barsik3" });

            db.SaveChanges();

            foreach (Dog item in db.Dogs.ToList<Dog>())
            {
                Console.WriteLine($"Id = {item.ID}, Name = {item.Name}");
            }
        }
    }
}
