using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Car (float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }

        public void Destroy()
        {

        }

    }
}
