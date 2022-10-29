using System;

namespace InterfacesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implementing exiting interface
            /*Ticket tk1 = new Ticket(7);
            Ticket tk2 = new Ticket(10);
            Console.WriteLine(tk2.Equals(tk1));*/

            // Implementing own interface
            Chair officechair = new Chair("Black", "plastic");
            Chair homechair = new Chair("Grey", "Metal");
            Car niceCar = new Car(200f, "Red");

            Car damagedCar = new Car(120f, "Blue");
            damagedCar.DestroyablesNearby.Add(officechair);
            damagedCar.DestroyablesNearby.Add(homechair);
            damagedCar.DestroyablesNearby.Add(niceCar);
            damagedCar.Destroy();
        }
    }
}
