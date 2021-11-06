using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductIBuyItem
    {
        [Key]
        public int BuyItemID { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int BuyAmount { get; set; }
        public decimal BuyCurrentPrice { get; set; }

        //public int ProGoup { get; set; }
        public int ProductBuyID { get; set; }
        //public ProductGroup ProductGroup { get; set; }
        public decimal Date { get; set; }
    }
}
