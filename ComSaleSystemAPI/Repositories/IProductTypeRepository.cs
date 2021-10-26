using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    interface IProductTypeRepository
    {
        public IEnumerable<ProductType> GetProductTypes();
        ProductType GetProductTypeById(int productId);
        void InsertProductType(ProductType product);
        void DeleteProductType(int productId);
        void UpdateProductType(ProductType product);
        void Save();
    }
}
