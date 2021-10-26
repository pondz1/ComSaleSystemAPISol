using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string EmpPosition { get; set; }
        public string EmpAddress { get; set; }
        public decimal EmpSalary { get; set; }
        public decimal EmpJoiningDate { get; set; }

    }
}
