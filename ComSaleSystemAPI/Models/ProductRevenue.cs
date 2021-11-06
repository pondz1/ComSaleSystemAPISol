using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductRevenue
    {
        public ProductRevenue(ProductType productType, List<ProductIBuyItem> products)
        {
            ProductType = productType;
            ProductBuys = products;
        }

        public virtual ProductType ProductType { get; set; }
        public virtual List<ProductIBuyItem> ProductBuys { get; set; }
    }
}
