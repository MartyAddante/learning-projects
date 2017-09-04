using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a sentence or multiple.");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'A')
                {
                    countA++;
                }
                if (sentence[i] == 'e' || sentence[i] == 'E')
                {
                    countE++;
                }
                if (sentence[i] == 'i' || sentence[i] == 'I')
                { 
                    countI++;
                }
                if (sentence[i] == 'o' || sentence[i] == 'O')
                {
                    countO++;
                }
                if (sentence[i] == 'u' || sentence[i] == 'U')
                {
                    countU++;
                }
                
            }

            Console.WriteLine("Total Words:" + words.Length);
            Console.WriteLine("Total vowels:" + (countA + countE + countI + countO + countU));
            Console.Write("\nTotal A:" + countA);
            Console.Write("\tTotal E:" + countE);
            Console.Write("\tTotal I:" + countI);
            Console.Write("\tTotal O:" + countO);
            Console.Write("\tTotal U:" + countU);
            Console.Write("\n\n");

        }
    }
}
