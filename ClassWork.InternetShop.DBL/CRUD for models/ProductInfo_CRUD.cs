using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.InternetShop.DBL.Interfaces;
using ClassWork.InternetShop.DBL.Models;

namespace ClassWork.InternetShop.DBL.CRUD_for_models
{
    public class ProductInfo_CRUD : ICRUD<ProductInfo> 
    {
        private static readonly InternetShop_DB DB = new InternetShop_DB();
        private static readonly ProductInfo_CRUD productInfo = null;
        private ProductInfo_CRUD()
        {

        }
        public static ProductInfo_CRUD GetInstanse()
        {
            return productInfo == null ? new ProductInfo_CRUD() : productInfo; 
        }

        public void Edit(ProductInfo t)
        {
            DB.ProductsInfo.Add(t);
            DB.SaveChanges();
        }

        public void UpDate(int id)
        {
            Console.Write("Введите новую массу: ");
            Read(id).Weight = Int32.Parse(Console.ReadLine());
            DB.SaveChanges();
        }

        public ProductInfo Read(int id)
        {
            return DB.ProductsInfo.Find(id);
        }

        public void Delete(int id)
        {
            DB.ProductsInfo.Remove(Read(id));
            DB.SaveChanges();
        }

        public ICollection<ProductInfo> ReadAll()
        {
            return DB.ProductsInfo.ToList<ProductInfo>();
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
