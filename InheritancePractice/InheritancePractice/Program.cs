using System;

namespace InheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Muñeca", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            //dog.IsHungry = false;
            //dog.IsHappy = false;
            dog.Eat();
            dog.MakeSound();
            dog.Play();
        }
    }
}
