using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL.Models;
using ClassWork.InternetShop.DBL.Interfaces;

namespace ClassWork.InternetShop.DBL.CRUD_for_models
{
     public class Product_CRUD : ICRUD<Product>
    {
        private static readonly InternetShop_DB DB = new InternetShop_DB();
        private static readonly Product_CRUD product = null;
        private Product_CRUD()
        {

        }
        public static Product_CRUD GetInstanse()
        {
            return product == null ? new Product_CRUD() : product;
        }
        public void Edit(Product product)
        {
            DB.Products.Add(product);
            DB.SaveChanges();
        }
        public void UpDate(Int32 id)
        {
            Console.Write("Введите новое название: ");
            Read(id).Name = Console.ReadLine();
            DB.SaveChanges();
        }
        public Product Read(Int32 id)
        {
            return DB.Products.Find(id);
        }
        public void Delete(Int32 id)
        {
            DB.Products.Remove(Read(id));
            DB.SaveChanges();
        }

        public void Dispose()
        {
            DB.Dispose();
        }

        public ICollection<Product> ReadAll()
        {
            return DB.Products.ToList<Product>();
        }
    }
}
