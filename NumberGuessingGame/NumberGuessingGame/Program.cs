using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a low number");
            int low = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick a high number");
            int high = int.Parse(Console.ReadLine());

            Random number = new Random();
            int randomNumber = number.Next(low, (high + 1));
            int count = 0;


            int guess;
            Console.WriteLine($"Guess a number between {low} and {high}");
            guess = int.Parse(Console.ReadLine());

            do
            {
                count++;
                                
                if(guess != randomNumber)
                {
                    Measure m = new Measure();
                    Console.WriteLine($"Your guess is {m.HowClose(guess, randomNumber)} than the number I'm thinking of");
                    Console.WriteLine("Please guess a new number");
                    guess = int.Parse(Console.ReadLine());
                }

            } while (guess != randomNumber);

            Console.WriteLine($"Congratulations, you guessed correctly in {count} guess(es)");

        }
    }
}
