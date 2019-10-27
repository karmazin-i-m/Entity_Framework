using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Model
{

    public class CRUD_Audience :IDisposable
    {
        private readonly DB_Model db = new DB_Model();

        public void Create(Audience audience)
        {
            if (audience != null)
            {
                db.Audiences.Add(audience);
                db.SaveChanges();
            }
            else throw new ArgumentNullException($" {nameof(audience)} был равен нулю");
        }

        public Audience Read(Int32 id)
        {
            return db.Audiences.Find(id);                         //Select((Audience t) => t).Where((t) => t.ID == id) as Audience;
        }

        public IEnumerable<Audience> ReadAll()
        {
            return db.Audiences.ToList();
        }

        public void UpDate(Int32 id)
        {
            Audience audience = db.Audiences.Find(id);

            if (audience != null)
            {
                Console.Write("Name: ");
                audience.Name = Console.ReadLine();
                Console.Write("NumberSeats: ");
                audience.NumberSeats = Int32.Parse(Console.ReadLine());

                db.Entry<Audience>(audience).CurrentValues.SetValues(audience);
                db.SaveChanges();
            }
            else
                Console.WriteLine("Обьект не найден");
        }

        public void Delete(Int32 id)
        {
            Audience audience = db.Audiences.Find(id);

            if (audience != null)
            {
                db.Audiences.Remove(audience);
                db.SaveChanges();
            }
            else
                Console.WriteLine("Обьект не найден");
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
