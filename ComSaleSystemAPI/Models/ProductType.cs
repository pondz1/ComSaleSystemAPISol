using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ProductType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        //public List<Product> Products { get; set; }
    }
}
