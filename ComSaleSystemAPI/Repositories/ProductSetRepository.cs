using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ComSaleSystemAPI.Repositories
{
    public class ProductSetRepository : IProductSetRepository
    {
        private SaleSystemContext context;
        public ProductSetRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }

        public void DeleteProductSetList(int[] productId)
        {
            foreach(int id in productId)
            {
                ProductSet product = context.ProductSets.Find(id);
                context.ProductSets.Remove(product);
            } 
        }

        public IEnumerable<ProductSet> GetByProGroup(int id)
        {
            return context.ProductSets.Where(a => a.PGID.Equals(id)).ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
