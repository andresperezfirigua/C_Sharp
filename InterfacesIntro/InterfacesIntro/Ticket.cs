using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfacesIntro
{
    internal class Ticket : IEquatable<Ticket>
    {
        public int DurInHours { get; set; }

        public Ticket (int durInHours)
        {
            this.DurInHours = durInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurInHours == other.DurInHours;
        }
    }
}
