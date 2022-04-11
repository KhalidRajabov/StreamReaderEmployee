using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderEmployee.Models
{
    internal class Employee
    {
        private int _id = 0;
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Id {
            get { return _id; }
                
            set { _id = value; }

                }

        public Employee()
        {

        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
            Id++;
        }

        public void ShowInfo()
        {
            Console.WriteLine("");
        }
    }
}
