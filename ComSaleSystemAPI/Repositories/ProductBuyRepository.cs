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
    public class ProductBuyRepository : IProductBuyRepository
    {
        private SaleSystemContext context;

        public ProductBuyRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }

        public void DeleteProductBuy(int productBuyId)
        {
            ProductBuy productBuy = context.ProductBuys.Find(productBuyId);
            context.ProductBuys.Remove(productBuy);
        }

        public ProductBuy GetProductBuyById(int productBuyId)
        {
            return context.ProductBuys.Find(productBuyId);
        }

        public IEnumerable<ProductBuy> GetProductBuys()
        {
            return context.ProductBuys.ToList();
        }

        public void InsertProductBuy(ProductBuy productBuy)
        {
            context.ProductBuys.Add(productBuy);
            foreach (ProductIBuyItem productIBuyItem in productBuy.ProductList)
            {
                Product product = productIBuyItem.Product;
                product.ProAmount -= productIBuyItem.BuyAmount;
                context.Entry(product).State = EntityState.Modified;

            }
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public IEnumerable<ProductBuy> SearchProductBuys(string key)
        {
            return context.ProductBuys
                        .Where(b => b.Customer.CusFirstName.Contains(key) || b.Customer.CusLastName.Contains(key) || b.Customer.CusAddress.Contains(key)).ToList();
        }

        //public IEnumerable<ProductBuy> SearchProductBuys(string key)
        //{
        //    return context.ProductBuys
        //                .Where(b => b.CusFirstName.Contains(key) || b.CusLastName.Contains(key) || b.CusAddress.Contains(key)).ToList();
        //}

        public void UpdateProductBuy(ProductBuy productBuy)
        {
            context.Entry(productBuy).State = EntityState.Modified;
        }
    }
}
