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
    public class ProductTypeRepository : IProductTypeRepository
    {
        private SaleSystemContext context;

        public ProductTypeRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }

        public void DeleteProductType(int productId)
        {
            ProductType product = context.ProductTypes.Find(productId);
            context.ProductTypes.Remove(product);
        }

        public ProductType GetProductTypeById(int productId)
        {
            return context.ProductTypes.Find(productId);
        }

        public IEnumerable<ProductType> GetProductTypes()
        {
            return context.ProductTypes.ToList();
        }

        public void InsertProductType(ProductType product)
        {
            context.ProductTypes.Add(product);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateProductType(ProductType product)
        {
            context.Entry(product).State = EntityState.Modified;
        }
    }
}
