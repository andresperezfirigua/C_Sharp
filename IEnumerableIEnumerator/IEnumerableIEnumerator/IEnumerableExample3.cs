using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumerableIEnumerator
{
    internal class IEnumerableExample3
    {
        public void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
