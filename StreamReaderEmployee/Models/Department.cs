using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StreamReaderEmployee.Models
{
    internal class Department
    {
        private int _id;
        public string Name { get; set; }
        public List <Employee>  Worker = new List<Employee>();
        public int Id
        {
            get { return _id; }

            set { _id = value; }

        }
        public Department()
        {

        }
        public Department(string name)
        {
            Name = name;
            Id++;
        }
        public void AddEmployee(Employee objct)
        {

        }
        public void GetEmployeesById(Employee id)
        {
        }
        public void RemoveEmployee(Employee id)
        {
        }
    }
}