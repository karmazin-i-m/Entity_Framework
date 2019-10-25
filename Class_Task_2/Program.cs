using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (InternetShopDBEntities db = new InternetShopDBEntities())
            {
                //var res = db.Customers.Where<Customers>((Customers customers) => true).Join<Orders, Customers,Int32,Orders>(() => )

                var res = from customer in db.Customers
                          join order in db.Orders on customer.ID equals order.CustomerID
                          join orderDetails in db.OrderDetails on order.ID equals orderDetails.OrderID
                          join product in db.Products on orderDetails.ProductID equals product.ID
                          join productDetails in db.ProductDetails on product.ID equals productDetails.ID
                          select new { customer = customer, product = product, productDetails = productDetails };

                foreach(var item in res)
                {
                    Console.WriteLine($"Покупатель {item.customer.FName+" "+item.customer.LName} приобрел: {item.product.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
