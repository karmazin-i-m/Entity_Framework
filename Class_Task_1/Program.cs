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
            using (InternetDB db = new InternetDB())
            {
                Product notebook1 = new Product() { ID = 1, Name = "Asus", ProductInfoID = 1, Orders = new List<Order>() };
                Product notebook2 = new Product() { ID = 2, Name = "Dell", ProductInfoID = 2, Orders = new List<Order>() };
                Product notebook3 = new Product() { ID = 3, Name = "HP", ProductInfoID = 3, Orders = new List<Order>() };
                Product notebook4 = new Product() { ID = 4, Name = "LG", ProductInfoID = 4, Orders = new List<Order>() };

                ProductInfo productInfo1 = new ProductInfo() { Information = "Notebook ASUS", ID = 1, Cost = 11111 };
                ProductInfo productInfo2 = new ProductInfo() { Information = "Notebook Dell", ID = 2, Cost = 22222 };
                ProductInfo productInfo3 = new ProductInfo() { Information = "Notebook HP", ID = 3, Cost = 33333 };
                ProductInfo productInfo4 = new ProductInfo() { Information = "Notebook LG", ID = 4, Cost = 44444 };

                Order order1 = new Order() { ID = 1, Products = new List<Product>() { notebook1, notebook4 } };
                Order order2 = new Order() { ID = 2, Products = new List<Product>() { notebook2, notebook3 } };

                notebook1.Orders.Add(order1);
                notebook2.Orders.Add(order2);
                notebook3.Orders.Add(order2);
                notebook4.Orders.Add(order1);

                Customer customer2 = new Customer();
                customer2.Orders.Add(order2);
                Customer customer1 = new Customer();
                customer1.Orders.Add(order1);

                Order order3 = new Order() { ID = 3, Products = new List<Product>() { notebook2, notebook1 }, Customer = customer1 };

                notebook1.Orders.Add(order3);
                notebook2.Orders.Add(order3);


                db.Products.AddRange(new List<Product>() { notebook1, notebook2, notebook3, notebook4 });
                db.ProductsInfo.AddRange(new List<ProductInfo>() { productInfo1, productInfo2, productInfo3, productInfo4 });
                db.Orders.AddRange(new List<Order> { order1, order2, order3 });
                db.Customers.AddRange(new List<Customer> { customer1, customer2 });

                db.SaveChanges();

            }

        }
    }
}

/*
            Product notebook1 = new Product() { ID = 1, Name = "Asus", ProductInfo = new ProductInfo() { Information = "Notebook ASUS", ID = 1, Cost = 11111, ProductID = 1 }, ProductInfoID = 1, Orders = new List<Order>()};
            Product notebook2 = new Product() { ID = 2, Name = "Dell", ProductInfo = new ProductInfo() { Information = "Notebook Dell", ID = 2, Cost = 22222, ProductID = 2 }, ProductInfoID = 2, Orders = new List<Order>() };
            Product notebook3 = new Product() { ID = 3, Name = "HP", ProductInfo = new ProductInfo() { Information = "Notebook HP", ID = 3, Cost = 33333, ProductID = 3 }, ProductInfoID = 3, Orders = new List<Order>() };
            Product notebook4 = new Product() { ID = 4, Name = "LG", ProductInfo = new ProductInfo() { Information = "Notebook LG", ID = 4, Cost = 44444, ProductID = 4 }, ProductInfoID = 4, Orders = new List<Order>() };

            ProductInfo productInfo1 = notebook1.ProductInfo;
            productInfo1.Product = notebook1;
            ProductInfo productInfo2 = notebook1.ProductInfo;
            productInfo2.Product = notebook2;
            ProductInfo productInfo3 = notebook1.ProductInfo;
            productInfo3.Product = notebook3;
            ProductInfo productInfo4 = notebook1.ProductInfo;
            productInfo4.Product = notebook4;


            Order order1 = new Order() { ID = 1, Products = new List<Product>() { notebook1, notebook4 }, Customer = new Customer() { Orders = new List<Order>() } };
            Order order2 = new Order() { ID = 2, Products = new List<Product>() { notebook2, notebook3 }, Customer = new Customer() { Orders = new List<Order>() } };

            notebook1.Orders.Add(order1);
            notebook2.Orders.Add(order2);
            notebook3.Orders.Add(order2);
            notebook4.Orders.Add(order1);

            Customer customer2 = order2.Customer;
            customer2.Orders.Add(order2);
            Customer customer1 = order1.Customer;
            customer1.Orders.Add(order1);

            Order order3 = new Order() { ID = 3, Products = new List<Product>() { notebook2, notebook1 }, Customer = customer1 };

            notebook1.Orders.Add(order3);
            notebook2.Orders.Add(order3);


            db.Products.AddRange(new List<Product>() { notebook1, notebook2, notebook3, notebook4 });
            db.ProductsInfo.AddRange(new List<ProductInfo>() { notebook1.ProductInfo, notebook2.ProductInfo, notebook3.ProductInfo, notebook4.ProductInfo });
            db.Orders.AddRange(new List<Order> { order1, order2, order3 });
            db.Customers.AddRange(new List<Customer> { customer1, customer2 });

            db.SaveChanges();
*/


