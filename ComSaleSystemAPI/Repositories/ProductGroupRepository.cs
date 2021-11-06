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
            //context.ProductSets.Where(a => a.PGID.Equals(ProductGroupId)).Include(a => a.Product).ToList();
            return context.ProductGroups.Find(ProductGroupId);
        }


        public IEnumerable<ProductGroup> GetProductGroups()
        {
            List<ProductGroup> PGList = context.ProductGroups.Include(a => a.Products).ToList();
            //foreach(ProductGroup productGroup in PGList)
            //{
            //    List<Product> products = new();
            //    foreach(ProductSet productSet in productGroup.Products)
            //    {

            //        productSet.Product = context.Products.Where(a => a.ProductId.Equals(productSet.ProductId));
            //    }

            //    //productGroup.Products
            //}
            return PGList;
        }

        public IEnumerable<ProductGroup> GetProductGroupsApprove()
        {
            List<ProductGroup> PGList = context.ProductGroups.Where(a => a.PGStatus == true).Include(a => a.Products).ToList();
            return PGList;
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
            var productSetToDelete = context.ProductSets.Where(a => a.PGID == ProductGroup.PGID).ToList();
            context.ProductSets.RemoveRange(productSetToDelete);
            context.SaveChanges();
            //List<ProductSet> ProductSets = new();
            //foreach (ProductSet productSet in ProductGroup.Products)
            //{
            //    ProductSets.Add(ProductSets);
            //}
            //context.ProductGroups.Up

            foreach (ProductSet productSet in ProductGroup.Products)
            {
                ProductSet ProductSet = new();
                ProductSet.PGID = productSet.PGID;
                ProductSet.Product = productSet.Product;
                ProductSet.ProductAmount = productSet.ProductAmount;
                ProductSet.ProductId = productSet.PGID;
                context.ProductSets.Add(productSet);
            }
            context.Entry(ProductGroup).State = EntityState.Modified;
        }

        public void UpdateStatusGroup(ProductGroup ProductGroup)
        {
            context.Entry(ProductGroup).State = EntityState.Modified;
        }
    }
}
