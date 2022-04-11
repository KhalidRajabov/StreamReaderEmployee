using System;

namespace StreamReaderEmployee.Models
{
    internal class Employee
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        private static int _count;

        public Employee()
        {
            _count++;
            _id += _count;

        }


        public void ShowInfo()
        {
            Console.WriteLine($"Worker name: {Name}\n" +
                $"Salary: {Salary}\n" +
                $"Worker ID: {_id}");
        }
    }
}
