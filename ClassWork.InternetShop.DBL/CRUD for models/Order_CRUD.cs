using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL.Interfaces;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.CRUD_for_models
{
    public class Order_CRUD : ICRUD<Order>
    {
        private static readonly InternetShop_DB DB = new InternetShop_DB();
        private static readonly Order_CRUD order = null;

        public static Order_CRUD GetInstanse()
        {
            return order == null ? new Order_CRUD() : order;
        }
        private Order_CRUD()
        {

        }

        public void Edit(Order t)
        {
            DB.Orders.Add(t);
            DB.SaveChanges();
        }

        public void UpDate(int id)
        {
            Console.WriteLine("Этот обьект не изменяем!");
        }

        public Order Read(int id)
        {
            return DB.Orders.Find(id);
        }

        public void Delete(int id)
        {
            DB.Orders.Remove(Read(id));
            DB.SaveChanges();
        }

        public ICollection<Order> ReadAll()
        {
            return DB.Orders.ToList<Order>(); ;
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
