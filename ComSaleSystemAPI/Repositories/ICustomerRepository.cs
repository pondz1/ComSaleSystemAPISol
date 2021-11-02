using ComSaleSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{
    interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> SearchCustomers(string key);
        Customer GetCustomerById(int customerId);
        void InsertCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(Customer customer);
        void Save();
    }
}
