using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    interface IProductGroupRepository
    {
        public IEnumerable<ProductGroup> GetProductGroups();
        ProductGroup GetProductGroupById(int ProductGroupId);
        void InsertProductGroup(ProductGroup ProductGroup);
        void DeleteProductGroup(int ProductGroupId);
        void UpdateProductGroup(ProductGroup ProductGroup);
        void Save();
    }
}
