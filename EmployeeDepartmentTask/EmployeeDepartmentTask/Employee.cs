using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDepartmentTask
{
    class Employee
    {

         public Employee()
        {
            _totalCount++;
            No = _totalCount;
        }
        
        static int _totalCount;
        public int No { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
    }
}
