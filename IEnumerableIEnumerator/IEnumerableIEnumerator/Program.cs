using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable example #1 - DogShelter class - Implementing IEnumerable members
            /*DogShelter ds = new DogShelter();

            foreach (Dog dog in ds)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }*/






            // IEnumerable example #2 - IEnumerableExample2 - Returning an IEnumerable collection

            /*IEnumerable<int> unknownCollection;
            IEnumerableExample2 example2 = new IEnumerableExample2();

            // This is for List
            unknownCollection = example2.GetCollection(1);

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
            // This is for Queue
            unknownCollection = example2.GetCollection(2);

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
            // This is for array of int
            unknownCollection = example2.GetCollection(5);

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }*/




            // IEnumerable example #3 - IEnumerableExample3 - Passing an IEnumerable collection as parameter

            /*List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            IEnumerableExample3 example3 = new IEnumerableExample3();
            
            Console.WriteLine(" ");
            
            example3.CollectionSum(numberList);

            Console.WriteLine(" ");

            example3.CollectionSum(numberArray);*/
        }
    }
}
