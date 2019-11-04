using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.Initializators
{
    public class InitializerObject : DropCreateDatabaseAlways<InternetShop_DB>
    {
        public override void InitializeDatabase(InternetShop_DB db)
        {
            base.InitializeDatabase(db);
        }
        protected override void Seed(InternetShop_DB db)
        {
            Product product1 = new Product() { Id = 1, Name = "Asus" };
            Product product2 = new Product() { Id = 2, Name = "HP" };
            Product product3 = new Product() { Id = 3, Name = "Apple" };
            Product product4 = new Product() { Id = 4, Name = "LG" };

            db.Products.Add(product1);
            db.Products.Add(product2);
            db.Products.Add(product3);
            db.Products.Add(product4);

            ProductInfo info1 = new ProductInfo() { Id = 1, Weight = 1300, Product = product1 };
            ProductInfo info2 = new ProductInfo() { Id = 2, Weight = 1400, Product = product2 };
            ProductInfo info3 = new ProductInfo() { Id = 3, Weight = 1500, Product = product3 };
            ProductInfo info4 = new ProductInfo() { Id = 4, Weight = 1600, Product = product4 };

            db.ProductsInfo.Add(info1);
            db.ProductsInfo.Add(info2);
            db.ProductsInfo.Add(info3);
            db.ProductsInfo.Add(info4);
            db.SaveChanges();


            Customer customer1 = new Customer() { Id = 1, Name = "Илья" };
            Customer customer2 = new Customer() { Id = 2, Name = "Лиля" };
            Customer customer3 = new Customer() { Id = 3, Name = "Олег" };
            Customer customer4 = new Customer() { Id = 4, Name = "Влад" };
            db.Customers.AddRange(new List<Customer>() { customer1, customer2, customer3, customer4 });
            db.SaveChanges();

            Order order1 = new Order() { Id = 1, Customer = customer4, Products = new List<Product>() { product1, product3 } };
            Order order2 = new Order() { Id = 2, Customer = customer3, Products = new List<Product>() { product2, product3 } };
            Order order3 = new Order() { Id = 3, Customer = customer2, Products = new List<Product>() { product4, product3, product2 } };
            Order order4 = new Order() { Id = 4, Customer = customer1, Products = new List<Product>() { product1, product4 } };
            db.Orders.AddRange(new List<Order>() { order1, order2, order3, order4 });
            db.SaveChanges();

        }
    }
}
