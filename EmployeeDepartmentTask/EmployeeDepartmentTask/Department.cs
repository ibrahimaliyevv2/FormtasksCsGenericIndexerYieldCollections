using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDepartmentTask
{
    class Department
    {
        public string Name { get; set; }
        List<Employee> Employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
                foreach (var item in Employees)
                {
                if (item.No==employee.No)
                {
                    return;
                }
                }
            Employees.Add(employee);
        }

        public void RemoveEmployeeByNo(int no)
        {
            Employee employee = GetEmployeeByNo(no);
            if (employee != null)
            {
                Employees.Remove(employee);
            }
        }

        public Employee GetEmployeeByNo(int no)
        {
            foreach (var item in Employees)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

        public void ChangeEmployeeNo(int oldNo, int newNo)
        {
            foreach (var item in Employees)
            {
                if(item.No == oldNo)
                {
                    item.No = newNo;
                }
            }
        }
    }
}
