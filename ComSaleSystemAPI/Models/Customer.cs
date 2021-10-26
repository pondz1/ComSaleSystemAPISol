using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CusFirstName { get; set; }
        public string CusLastName { get; set; }
        public string CusAddress { get; set; }
    }
}
