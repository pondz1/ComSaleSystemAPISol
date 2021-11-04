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

        public IEnumerable<ProductSet> GetByProGroup(int id)
        {
            return context.ProductSets.Where(a => a.PGID.Equals(id)).Include(a => a.Product).Include(a => a.Product.ProType).ToList();
        }
    }
}
