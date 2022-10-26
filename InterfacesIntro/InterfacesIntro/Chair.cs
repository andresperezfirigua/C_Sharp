using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal class Chair : Furniture
    {
        public Chair (string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
