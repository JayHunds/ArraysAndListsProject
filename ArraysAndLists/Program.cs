using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evens = new List<int>();

            List<int> odds = new List<int>();
            
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            Console.WriteLine("Even Numbers: ");
            for (int i = 0; i < evens.Count; i++) 
            {
                Console.WriteLine(evens[i]);            
            }

            Console.WriteLine("Odd Numbers: ");
            for (int i = 0; i < odds.Count; i++) 
            {
                Console.WriteLine(odds[i]);            
            }


     
        }
    }
}
