using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using System.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Repositories
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private SaleSystemContext context;

        public EmployeeRepository(SaleSystemContext systemContext)
        {
            context = systemContext;
        }
        public void DeleteEmployee(int employeeId)
        {
            Employee employee = context.Employees.Find(employeeId);
            context.Employees.Remove(employee);
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return context.Employees.Find(employeeId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            context.Employees.Add(employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
        }
    }
}
