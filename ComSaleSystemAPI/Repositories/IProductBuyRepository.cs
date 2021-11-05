using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    interface IProductBuyRepository
    {
        IEnumerable<ProductBuy> GetProductBuys();
        IEnumerable<ProductBuy> SearchProductBuys(string key);
        ProductBuy GetProductBuyById(int productBuyId);
        void InsertProductBuy(ProductBuy productBuy);
        void DeleteProductBuy(int productBuyId);
        void UpdateProductBuy(ProductBuy productBuy);
        void Save();
    }
}
