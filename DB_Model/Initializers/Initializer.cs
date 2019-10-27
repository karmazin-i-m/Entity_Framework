using System.Collections.Generic;
using System.Data.Entity;

namespace DB_Model
{
    internal class Initializer : DropCreateDatabaseAlways<DB_Model>
    {
        protected override void Seed(DB_Model context)
        {
            List<Audience> audiences = new List<Audience>()
            {
                new Audience()
                {
                    Area = 10,
                    NumberSeats = 5,
                    Name = "512b"
                },
                new Audience()
                {
                    Area = 6,
                    NumberSeats = 4,
                    Name = "512a"
                },
                new Audience()
                {
                    Area = 33,
                    NumberSeats = 20,
                    Name = "512c"
                }
            };

            foreach(var item in audiences)
            {
                context.Audiences.Add(item);
            }

            context.SaveChanges();
        }
    }
}