using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_AdditionTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 db = new Model1();

            Product product1 = new Product() { ID = 1, Name = "Prod1" };
            Product product2 = new Product() { ID = 2, Name = "Prod2" };
            Product product3 = new Product() { ID = 1, Name = "Prod3" };

            Order order1 = new Order() { ID = 1, };
            Order order2 = new Order() { ID = 2, };

            order1.Products.Add(product1);
            order1.Products.Add(product3);
            order2.Products.Add(product2);

            db.Products.AddRange(new List<Product>() { product1, product2, product3 });
            db.Orders.AddRange(new List<Order>() { order1, order2});

            db.SaveChanges();
            Console.ReadKey();
        }
    }

    public class Order
    {
        public Int32 ID { get; set; }
        public ICollection<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

    }

    public class Product
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Product()
        {
            Orders = new List<Order>();
        }
    }
}
