using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair (string color, string material)
        {
            this.Color = color;
            this.Material = material;
            this.DestructionSound = "ChairExplosionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed!");
            Console.WriteLine("Playing the destruction sound {0} for chair", DestructionSound);
            Console.WriteLine("Spawning chair parts!");
        }
    }
}
