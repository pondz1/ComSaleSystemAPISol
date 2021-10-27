using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private SaleSystemContext context;

        public ProductRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }

        public void DeleteProduct(int productId)
        {
            Product product = context.Products.Find(productId);
            context.Products.Remove(product);
        }

        public Product GetProductById(int productId)
        {
            return context.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts(string id)
        {
            if(id == "All")
            {
                return context.Products.Include(a => a.ProType).ToList();
            } else
            {
                int myID = Int32.Parse(id);
                return context.Products.Include(a => a.ProType).Where(b => b.TypeId == myID).ToList();
            }
            
        }

        public void InsertProduct(Product product)
        {
            context.Products.Add(product);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
        }
    }
}
