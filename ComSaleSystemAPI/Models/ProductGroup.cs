using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductGroup
    {
        [Key]
        public int PGID { get; set; }
        public string PGName { get; set; }
        public decimal PGPrice { get; set; }
        public bool PGStatus { get; set; }
        public virtual List<ProductSet> Products { get; set; }
    }
}
