using System;
using System.Collections;
using StreamReaderEmployee.Models;
namespace StreamReaderEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.Name = "Xalid";
            emp1.Salary = 540.82;
            emp1.ShowInfo();
            emp2.Name = "Someone";
            emp2.Salary = 532.35;
            emp2.ShowInfo();
            Department department = new Department();
            department.Name = "Devolopers";
            department.AddEmployee(emp1);
            department.AddEmployee(emp2);

            department.ShowDepWorkers();
        }
    }
}
