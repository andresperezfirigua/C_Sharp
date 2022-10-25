using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee() {
            this.Name = "Andres Felipe Perez";
            this.FirstName = "Andres";
            this.Salary = 460;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Hey, I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("Hey, I took a break");
        }
    }
}
