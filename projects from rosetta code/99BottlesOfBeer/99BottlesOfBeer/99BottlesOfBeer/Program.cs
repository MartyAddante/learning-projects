using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99BottlesOfBeer
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 99; i > 0; i--)
            {
                string line;
                string minusOne;
                string wall = "on the wall";
                
                if (i != 1)
                {
                    line = $"{i} bottles of beer";
                    minusOne = $"{i - 1} bottles of beer";
                }
                else
                {
                    line = $"{i} bottle of beer";
                    minusOne = $"no more bottles of beer";
                }

                Console.WriteLine($"{line} {wall}\n{line}\nTake one down, pass it around\n{minusOne} {wall}\n\n");
            }
            
        }
    }
}
