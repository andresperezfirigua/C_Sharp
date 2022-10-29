﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumerableIEnumerator
{
    internal class IEnumerableExample2
    {
        public IEnumerable<int> GetCollection(int option)
        {
            // Create a list of numbers and initialize it
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5};

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1)
                return numberList;
            else if(option == 2)
                return numbersQueue;
            else
                return new int[] { 11, 12, 13, 14, 15 };
        }
    }
}
