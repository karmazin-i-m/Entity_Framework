using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.Initializators
{
    internal class InitializerObject : DropCreateDatabaseAlways<InternetShop_DB>
    {
        protected override void Seed(InternetShop_DB context)
        {
            Product product1 = new Product() { Name = "Asus" };
            Product product2 = new Product() { Name = "HP" };
            Product product3 = new Product() { Name = "Apple" };
            Product product4 = new Product() { Name = "LG" };

            ProductInfo info1 = new ProductInfo() { Product = product1, Weight = 1300 };
            ProductInfo info2 = new ProductInfo() { Product = product2, Weight = 1400 };
            ProductInfo info3 = new ProductInfo() { Product = product3, Weight = 1500 };
            ProductInfo info4 = new ProductInfo() { Product = product4, Weight = 1600 };

            Customer customer1 = new Customer() { Name = "Илья" };
            Customer customer2 = new Customer() { Name = "Лиля" };
            Customer customer3 = new Customer() { Name = "Олег" };
            Customer customer4 = new Customer() { Name = "Влад" };

            Order order1 = new Order() { Customer = customer4, Products = new List<Product>() { product1, product3 } };
            Order order2 = new Order() { Customer = customer3, Products = new List<Product>() { product2, product3 } };
            Order order3 = new Order() { Customer = customer2, Products = new List<Product>() { product4, product3, product2 } };
            Order order4 = new Order() { Customer = customer1, Products = new List<Product>() { product1, product4 } };

            context.Orders.AddRange(new List<Order>() { order1, order2, order3, order4 });
            context.ProductsInfo.AddRange(new List<ProductInfo>() { info1, info2, info3, info4 });
            context.Products.AddRange(new List<Product>() { product1, product2, product3, product4 });
            context.Customers.AddRange(new List<Customer>() { customer1, customer2, customer3, customer4 });
            context.SaveChanges();
        }
    }
}
