using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProName { get; set; }
        public decimal ProPrice { get; set; }

        //[ForeignKey("ProductType")]
        public int TypeId { get; set; }
        public ProductType ProType { get; set; }

        public string ProBrand { get; set; }
        public string ProModel { get; set; }
        public string ProDetail { get; set; }
        public string ProImage { get; set; }
        public int ProAmount { get; set; }

        //public int GroupId { get; set; }
        //public ProductGroup ProGroup { get; set; }

    }
}
