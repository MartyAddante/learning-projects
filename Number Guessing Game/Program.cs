using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate random number between 1 and 1000;
            Random number = new Random();
            int randomNumber = number.Next(0, 1000);
            int count = 0;
            
            //Ask user for a guess
            Console.WriteLine("I'm thinking of a number between 0 and 1000. Go ahead guess.");
            

            //Designate a return point after the guess is checked
            Beginning:
            //read guess and parse it into an int
            string guess = Console.ReadLine();
            int guessToInt = int.Parse(guess);
            
            //correct guess
            if (guessToInt == randomNumber)
            {
                Console.WriteLine("Finally! You guessed correctly. I thought I'd be waiting all day.");
                count++;
                Console.WriteLine("It only took you " + count + " guesses.");
            }
            //Low guesses start here
            else if ((guessToInt >= 0) && (guessToInt < (randomNumber - 700)))
            {
                Console.WriteLine("Do you understand how guessing works? guess like a mile higher.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            else if (guessToInt <= (randomNumber - 500))
            {
                Console.WriteLine("UUGH! Is that even a real guess? Guess way way way higher.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            else if ((guessToInt <= (randomNumber - 100)) && (guessToInt >= (randomNumber - 500)))
            {
                Console.WriteLine("I would like if this didn't take all day. Guess higher.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }           
            else if ((guessToInt < (randomNumber - 10)) && (guessToInt >= (randomNumber - 100)))
            {
                Console.WriteLine("Higher.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            else if ((guessToInt > (randomNumber - 10)) && (guessToInt <= (randomNumber - 5)))
            {
                Console.WriteLine("Oh So close. Just a little higher.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            //Guesses within 5
            else if ((guessToInt <= (randomNumber + 5)) && (guessToInt >= (randomNumber - 5)) && (guessToInt != randomNumber))
            {
                Console.WriteLine("You are within a five or less5.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            //High guesses start here
            else if ((guessToInt < (randomNumber + 10)) && (guessToInt > (randomNumber + 5)))
            {
                Console.WriteLine("Oh So close. Just a little lower.\n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            else if ((guessToInt > (randomNumber + 10)) && (guessToInt < (randomNumber + 100)))
            {
                Console.WriteLine("Lower. \n\n\n\n" + guess);
                count++;
                goto Beginning;
            }
            else if ((guessToInt >= (randomNumber + 100)) && (guessToInt <= (randomNumber +300)))
            {
                Console.WriteLine("I don't think you're very good at this. You need to guess significantly lower than you just did. \n\n\n\n" + "last guess:" + guess);
                count++;
                goto Beginning;
            }
            else if (guessToInt > (randomNumber + 600))
            {
                Console.WriteLine("Seriously? You just need to guess better. Guess lower, like a lot lower.\n\n\n\n" + "last guess:" + guess);
                count++;
                goto Beginning;
            }
            else if ((guessToInt <= 1000) && (guessToInt > (randomNumber + 600)))
            {
                Console.WriteLine("I see the concept of guessing well is lost on you. In the future guess more better, and a crapload lower.\n\n\n\n" + "last guess:" + guess);
                count++;
                goto Beginning;
            }
            //for cases where guesses are higher or lower than the bounds of the if and else if statements
            else
            {
                Console.WriteLine("I'm not even going to justify that with a response.\n\n\n\n" + "last guess: " + guess);
                count++;
                goto Beginning;
            }
            






        }
    }
}
