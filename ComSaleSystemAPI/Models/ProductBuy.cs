using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductBuy
    {
        [Key]
        public int ProductBuyID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public List<ProductIBuyItem> ProductList { get; set; }
        public decimal Coupon { get; set; }
        public decimal Date { get; set; }
    }
}
