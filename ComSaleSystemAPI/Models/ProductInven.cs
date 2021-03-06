using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductInven
    {
        public ProductInven(ProductType productType, List<Product> products)
        {
            ProductType = productType;
            Products = products;
        }

        public virtual ProductType ProductType { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
