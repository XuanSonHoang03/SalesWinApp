using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        public Ass02SolutionContext context = new Ass02SolutionContext();
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }
        public void DeleteProduct(int id)
        {
            Product product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
        }
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
    }
}
