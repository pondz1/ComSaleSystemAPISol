using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProName { get; set; }
        public decimal ProPrice { get; set; }
        public int ProType { get; set; }
        public string ProBrand { get; set; }
        public string ProModel { get; set; }
        public string ProDetail { get; set; }

    }
}
