﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnumerableIEnumerator
{
    // IEnumerable example #1
    internal class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Dog: {0} said guau {1} times!", Name, numberofTreats);
        }
    }
}
