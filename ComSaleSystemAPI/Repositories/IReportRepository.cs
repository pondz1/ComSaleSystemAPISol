using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    interface IReportRepository
    {
        IEnumerable<ProductInven> InventoryReport();
        IEnumerable<ReportCustomer> GetReportCustomers();
        IEnumerable<ReportCustomer> GetReportCustomerSerach(string key);
        IEnumerable<ProductIBuyItem> GetProductBuyItemsByID(int id);
    }
}
