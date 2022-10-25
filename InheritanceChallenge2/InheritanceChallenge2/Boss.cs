﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge2
{
    internal class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss() { }

        public Boss (string name, string firstName, int salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;

            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Hey, I'm leading");
        }
    }
}
