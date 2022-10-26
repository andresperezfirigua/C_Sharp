using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public Furniture()
        {
            this.Color = "Red";
            this.Material = "Wood";
        }
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
