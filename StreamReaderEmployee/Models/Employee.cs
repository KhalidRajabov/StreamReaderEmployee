using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderEmployee.Models
{
    internal class Employee
    {
        private static int _id=0;
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Id {
            get;
        }

        public Employee()
        {

            Id += _id;

        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Worker name: {Name}\n" +
                $"Salary: {Salary}\n" +
                $"Worker ID: {_id}");
        }
    }
}
