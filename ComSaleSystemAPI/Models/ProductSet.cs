using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductSet
    {
        [Key]
        public int SetId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int ProductAmount { get; set; }

        //public int ProGoup { get; set; }
        public int PGID { get; set; }
        //public ProductGroup ProductGroup { get; set; }
    }
}
