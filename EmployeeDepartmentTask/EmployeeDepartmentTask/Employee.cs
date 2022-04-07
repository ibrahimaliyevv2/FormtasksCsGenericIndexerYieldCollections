using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDepartmentTask
{
    class Employee
    {

        public Employee()
        {
            _no++;
            No = _no;
        }

        private static int _no;
        public int No { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
    }
}
