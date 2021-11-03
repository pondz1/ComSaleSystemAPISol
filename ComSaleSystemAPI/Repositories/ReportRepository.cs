using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using System.Data.Entity;

namespace ComSaleSystemAPI.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly SaleSystemContext context;

        public ReportRepository(SaleSystemContext c)
        {
            context = c;
        }

        public IEnumerable<ProductInven> InventoryReport()
        {
            List<ProductType> pt = context.ProductTypes.ToList();
            List<ProductInven> productInvens = new();
            foreach(ProductType productType in pt)
            {
                List<Product> products = context.Products.Include(a => a.ProType).Where(b => b.TypeId == productType.TypeID).ToList();
                ProductInven productInven = new(productType, products);
                productInvens.Add(productInven);
            }
            return productInvens;
        }
    }
}
