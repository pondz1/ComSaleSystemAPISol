using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ReportCustomer
    {
        public virtual Customer Customer { get; set; }
        public virtual List<ProductBuy> ProductBuys { get; set; }
    }
}
