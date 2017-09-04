using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        //Write a program that prints intergers from 1 to 100 (inclusive).
        //for multiples of 3 print fizz
        //for multiples of 5 print buzz
        //for multiples of both 5 and 3 print fizzbuzz
        static void Main(string[] args)
        {
            int[] fizzbuzz = new int[100];

            for (int i = 0, j = 0; i < fizzbuzz.Length; i++, j++)
            {
                fizzbuzz[i] = i + 1;
                Console.Write(fizzbuzz[i]);
                if (fizzbuzz[i] % 3 == 0)
                {                    
                    Console.Write("Fizz");
                }
                if (fizzbuzz[i] % 5 == 0)
                {                    
                    Console.Write("Buzz");
                }
                Console.Write(" ");
                



            }

        }
    }
}
