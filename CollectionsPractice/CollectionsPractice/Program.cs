using System;

namespace CollectionsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value: ");
            String firstValue = Console.ReadLine();
            Console.WriteLine("Please select the Data Type to validate the input you have entered");
            Console.WriteLine("Press 1 for String \nPress 2 for Integer \nPress 3 for Boolean");
            if (int.TryParse(Console.ReadLine(), out int option)){
                Console.WriteLine("You have entered the following value: {0}", firstValue);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Holii");
                        break;
                    case 2:
                        if(int.TryParse(firstValue, out int value))
                        {
                            Console.WriteLine("It is a valid Integer");
                        } else
                        {
                            Console.WriteLine("It is an invalid Integer");
                        }
                        break;
                    case 3:
                        if(bool.TryParse(firstValue, out bool boolValue))
                        {
                            Console.WriteLine("It is a valid Boolean");
                        } else
                        {
                            Console.WriteLine("It is an invalid Boolean");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            } else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
