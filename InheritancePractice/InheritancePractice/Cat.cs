using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    internal class Cat : Animal
    {
        public bool IsResting { get; set; }
        public Cat (string name, int age) : base (name, age)
        {
            IsResting = true;
        }


    }
}
