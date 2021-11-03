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

        public ProductType ProductType { get; set; }
        public List<Product> Products { get; set; }
    }
}
