using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL;
using ClassWork.InternetShop.DBL.Models;
using ClassWork.InternetShop.DBL.CRUD_for_models;

using System.Data.Entity;

namespace ClassWork_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product_CRUD product_CRUD = Product_CRUD.GetInstanse();
            Order_CRUD order_CRUD = Order_CRUD.GetInstanse();
            ProductInfo_CRUD productInfo_CRUD = ProductInfo_CRUD.GetInstanse();
            Customer_CRUD customer_CRUD = Customer_CRUD.GetInstanse();

            product_CRUD.Edit(new Product() { Name = "Lenovo", ProductInfo = new ProductInfo() { Weight = 12 } });
            customer_CRUD.Delete(3);
            customer_CRUD.Edit(new Customer() { Name = " Виталий" });
            customer_CRUD.UpDate(5);

            foreach (var item in product_CRUD.ReadAll())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 80));
            foreach (var item in order_CRUD.ReadAll())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 80));
            foreach (var item in productInfo_CRUD.ReadAll())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 80));
            foreach (var item in customer_CRUD.ReadAll())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
