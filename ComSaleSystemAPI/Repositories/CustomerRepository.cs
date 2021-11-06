using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private SaleSystemContext context;

        public CustomerRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }

        public void DeleteCustomer(int customerId)
        {
            Customer customer = context.Customers.Find(customerId);
            context.Customers.Remove(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.Where(a => a.Visible == true).ToList();
        }

        public void InsertCustomer(Customer customer)
        {
            context.Customers.Add(customer);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public IEnumerable<Customer> SearchCustomers(string key)
        {
            return context.Customers
                        .Where(b => b.CusFirstName.Contains(key) || b.CusLastName.Contains(key) || b.CusAddress.Contains(key)).ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }
    }
}
