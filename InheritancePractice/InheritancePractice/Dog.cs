using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog (string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Guau!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine($"{Name} is not feeling happy to play now");
            }
        }
    }
}
