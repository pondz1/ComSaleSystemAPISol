using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Context
{
    public class SaleSystemContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ApproveList> ApproveLists { get; set; }
        public DbSet<ProductSet> ProductSets { get; set; }
        public DbSet<ProductBuy> ProductBuys { get; set; }
    }
}
