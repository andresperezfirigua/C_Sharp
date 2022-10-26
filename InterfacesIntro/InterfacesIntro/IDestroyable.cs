using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIntro
{
    internal interface IDestroyable
    {
        // Property to store audio file of the destruction sound 
        string DestructionSound { get; set; }
        // Method to destroy an object
        void Destroy();
    }
}
