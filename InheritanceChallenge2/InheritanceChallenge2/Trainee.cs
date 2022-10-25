using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge2
{
    internal class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee() { }
        public Trainee(string name, string firsName, int salary, int workingHours, int schoolHours) : base (name,firsName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Hey, I'm learning");
        }

        public override void Work()
        {
            Console.WriteLine("Working hours for the trainee are {0}", WorkingHours);
        }
    }
}
