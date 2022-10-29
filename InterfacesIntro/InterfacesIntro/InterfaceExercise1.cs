using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    // place for your classes and an interface
    interface IShootable
    {
        void Shoot();
    }

    class Weapon
    {
        public string Name { get; set; }
        public Weapon() 
        {
            this.Name = "Gun";
        }
        public Weapon(string name)
        {
            this.Name = name;
        }

        public void Label()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    class Gun : Weapon, IShootable
    {
        public Gun() { }
        public Gun(string name) : base(name) { }
        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }
    }

    /*public static class Program
    {
        static public void Main(string[] args)
        {
            // new instance 
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying the interface and the parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        }
    }*/
}
