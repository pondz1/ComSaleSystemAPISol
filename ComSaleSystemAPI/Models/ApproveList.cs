using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class ApproveList
    {
        [Key]
        public int AppID { get; set; }
        public int AppStatus { get; set; }

        public int PGID { get; set; }
        public ProductGroup ProductGroup  { get; set; }
    }
}
