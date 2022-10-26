using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }
        public Vehicle ()
        {
            this.Speed = 100f;
            this.Color = "Black";
        }
        public Vehicle (float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        } 
    }
}
