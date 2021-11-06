using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using System.Data.Entity;

namespace ComSaleSystemAPI.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly SaleSystemContext context;

        public ReportRepository(SaleSystemContext c)
        {
            context = c;
        }

        public IEnumerable<ReportCustomer> GetReportCustomers()
        {
            //throw new NotImplementedException();
            List<Customer> customers = context.Customers.Where(a => a.Visible == true).ToList();
            List<ReportCustomer> ReportCustomer = new();
            foreach (Customer customer in customers)
            {
                List<ProductBuy> productBuys = context.ProductBuys.Where(a => a.CustomerID.Equals(customer.CustomerID)).ToList();
                ReportCustomer reportCustomer = new();
                reportCustomer.Customer = customer;
                reportCustomer.ProductBuys = productBuys;
                ReportCustomer.Add(reportCustomer);
            }
            return ReportCustomer;
        }

        public IEnumerable<ProductInven> InventoryReport()
        {
            List<ProductType> pt = context.ProductTypes.ToList();
            List<ProductInven> productInvens = new();
            foreach (ProductType productType in pt)
            {
                List<Product> products = context.Products.Where(b => b.TypeId == productType.TypeID).ToList();
                ProductInven productInven = new(productType, products);
                productInvens.Add(productInven);
            }
            return productInvens;
        }

        public IEnumerable<ReportCustomer> GetReportCustomerSerach(string key)
        {
            int id;
            List<Customer> customers = new();
            if (int.TryParse(key, out id))
            {
                customers = context.Customers
                .Where(a => a.Visible == true)
                .Where(a => a.CusFirstName.Contains(key) || a.CusLastName.Contains(key) || a.CusAddress.Contains(key) || a.CustomerID.Equals(id))
                .ToList();
            } else
            {
                customers = context.Customers
                .Where(a => a.Visible == true)
                .Where(a => a.CusFirstName.Contains(key) || a.CusLastName.Contains(key) || a.CusAddress.Contains(key))
                .ToList();
            }
            

            List<ReportCustomer> ReportCustomer = new();
            foreach (Customer customer in customers)
            {
                List<ProductBuy> productBuys = context.ProductBuys.Where(a => a.CustomerID.Equals(customer.CustomerID)).ToList();
                ReportCustomer reportCustomer = new();
                reportCustomer.Customer = customer;
                reportCustomer.ProductBuys = productBuys;
                ReportCustomer.Add(reportCustomer);
            }
            return ReportCustomer;
        }

        public IEnumerable<ProductIBuyItem> GetProductBuyItemsByID(int id)
        {
            return context.ProductIBuyItems.Where(a => a.ProductBuyID == id).ToList();
        }

        public IEnumerable<ProductRevenue> GetProductBuyItems()
        {
            List<ProductType> pt = context.ProductTypes.ToList();
            List<ProductRevenue> ProductRevenues = new();
            foreach (ProductType productType in pt)
            {
                var products = context.ProductIBuyItems.Where(b => b.Product.TypeId == productType.TypeID).ToList();
                ProductRevenue ProductRevenue = new(productType, products);
                ProductRevenues.Add(ProductRevenue);
            }
            return ProductRevenues;
        }
    }
}
