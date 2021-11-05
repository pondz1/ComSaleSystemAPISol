using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    interface IProductSetRepository
    {
        public IEnumerable<ProductSet> GetByProGroup(int id);
        public void DeleteProductSetList(int[] productId);
        public void Save();
    }
}
