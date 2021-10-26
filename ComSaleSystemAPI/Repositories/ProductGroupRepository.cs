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
    public class ProductGroupRepository : IProductGroupRepository
    {
        private SaleSystemContext context;

        public ProductGroupRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }

        public void DeleteProductGroup(int ProductGroupId)
        {
            ProductGroup ProductGroup = context.ProductGroups.Find(ProductGroupId);
            context.ProductGroups.Remove(ProductGroup);
        }

        public ProductGroup GetProductGroupById(int ProductGroupId)
        {
            return context.ProductGroups.Find(ProductGroupId);
        }

        public IEnumerable<ProductGroup> GetProductGroups()
        {
            return context.ProductGroups.ToList();
        }

        public void InsertProductGroup(ProductGroup ProductGroup)
        {
            context.ProductGroups.Add(ProductGroup);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateProductGroup(ProductGroup ProductGroup)
        {
            context.Entry(ProductGroup).State = EntityState.Modified;
        }
    }
}
