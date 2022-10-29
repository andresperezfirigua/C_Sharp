using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;
        public Car (float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            this.DestructionSound = "CarExplosionSound.mp3";
            this.DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Explosion sound for car! {0}",DestructionSound);
            Console.WriteLine("Fire effect");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

    }
}
