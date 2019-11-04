using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL.Interfaces;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.CRUD_for_models
{
    public class Customer_CRUD : ICRUD<Customer>
    {
        private static readonly InternetShop_DB DB = new InternetShop_DB();
        private static readonly Customer_CRUD customer = null;
        
        public static Customer_CRUD GetInstanse()
        {
            return customer == null ? new Customer_CRUD() : customer;
        }

        public void Edit(Customer t)
        {
            DB.Customers.Add(t);
            DB.SaveChanges();
        }

        public void UpDate(int id)
        {
            Console.Write("Введите новое имя: ");
            Read(id).Name = Console.ReadLine();
            DB.SaveChanges();
        }

        public Customer Read(int id)
        {
            return DB.Customers.Find(id);
        }

        public void Delete(int id)
        {
            DB.Customers.Remove(Read(id));
            DB.SaveChanges();
        }

        public ICollection<Customer> ReadAll()
        {
            return DB.Customers.ToList<Customer>();
        }

        public void Dispose()
        {
            DB.Dispose();
        }

        private Customer_CRUD()
        {

        }
    }
}
