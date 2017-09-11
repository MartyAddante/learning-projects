using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a sentence");
            string pigRecieve = Console.ReadLine();
            string[] pigArray = pigRecieve.Split(' ');
            
            

            for(int i = 0; i < pigArray.Length; i++)
            {
                pigArray[i] = pigArray[i].Replace('.', " ");
                string stringPig = pigArray[i].ToLower();
                
                if(stringPig[0] == 'a' || stringPig[0] == 'e' || stringPig[0] == 'i' || stringPig[0] == 'o' || stringPig[0] == 'u')
                {
                    string firstLetter = stringPig.Substring(0, 1);
                    stringPig = stringPig.Substring(1, stringPig.Length() - 1);
                    Console.Write(stringPig);
                    Console.Write("yay");
                    Console.Write(" ");
                }
                else
                {
                    string firstLetter = stringPig.Substring(0, 1);
                    stringPig = stringPig.Substring(1, stringPig.Length() - 1);
                    Console.Write(stringPig);
                    Console.Write("ay");
                    Console.Write(" ");
                }
                
            }
            Console.Write(".\n");
        }
    }
}
