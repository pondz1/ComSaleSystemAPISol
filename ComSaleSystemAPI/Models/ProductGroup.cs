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
        public int PrGrID { get; set; }
        public string PrGrProduct { get; set; }
        public decimal PrGrPrice { get; set; }
    }
}
